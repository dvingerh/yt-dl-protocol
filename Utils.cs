using Microsoft.Win32;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace yt_dl_protocol
{
    public static class Utils
    {
        public static bool RegisterURLProtocol(string protocol, string applicationPath, string description, bool silent= true)
        {
            try
            {
                RegistryKey key = Registry.ClassesRoot.CreateSubKey(protocol);
                key.SetValue(string.Empty, "URL:" + description);
                key.SetValue("URL Protocol", string.Empty);

                using (RegistryKey defaultIcon = key.CreateSubKey("DefaultIcon"))
                {
                    defaultIcon.SetValue(string.Empty, applicationPath + ",1");
                }

                using (RegistryKey shellKey = key.CreateSubKey(@"shell\open\command"))
                {
                    shellKey.SetValue(string.Empty, $"\"{applicationPath}\" \"%1\"");
                }
                if (silent)
                    MessageBox.Show("Protocol registered successfully. Do not rename this executable or move it to another location.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (silent)
                    MessageBox.Show($"Failed to register protocol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool IsProtocolRegistered(string protocol)
        {
            string applicationPath = Assembly.GetExecutingAssembly().Location;
            try
            {
                using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(protocol))
                {
                    if (key == null)
                    {
                        return false;
                    }

                    using (RegistryKey shellKey = key.OpenSubKey(@"shell\open\command"))
                    {
                        if (shellKey == null)
                        {
                            return false;
                        }

                        string registeredApplicationPath = shellKey.GetValue(string.Empty) as string;
                        if (registeredApplicationPath == null)
                        {
                            return false;
                        }

                        registeredApplicationPath = registeredApplicationPath.Replace("\"%1\"", "").Trim('\"', ' ');

                        return string.Equals(registeredApplicationPath, applicationPath, StringComparison.OrdinalIgnoreCase);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to check protocol registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool RemoveOrphanedKeys(string protocol)
        {
            try
            {
                using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(protocol))
                {
                    if (key == null)
                    {
                        return true;
                    }
                }
                Registry.ClassesRoot.DeleteSubKeyTree(protocol);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool UnregisterURLProtocol(string protocol, bool silent = true)
        {
            Registry.ClassesRoot.DeleteSubKeyTree(protocol, false);
            bool cleanedOrphanedKeys = RemoveOrphanedKeys(protocol);
            if (cleanedOrphanedKeys)
                if (silent)
                    MessageBox.Show("The protocol has been unregistered. To re-register, run the program again to open the configuration menu.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                if (silent)
                    MessageBox.Show("The protocol has been unregistered, but some orphaned registry keys may not be removed.\n\nTo re-register, run the program again to open the configuration menu.", "Success with warnings", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return false;
        }

    }
}
