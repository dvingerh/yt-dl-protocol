using System;
using System.Windows.Forms;

namespace yt_dl_protocol
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length > 0)
            {
                string arg = string.Join(" ", args).Replace("ytdl://", "").Trim();

                switch (arg)
                {
                    case "register":
                        Utils.RegisterURLProtocol("ytdl", Application.ExecutablePath, "yt-dl-protocol-handler");
                        break;
                    case "unregister":
                        Utils.UnregisterURLProtocol("ytdl");
                        break;
                    case "configuration":
                        var configForm = new ConfigurationForm();
                        configForm.ShowDialog();
                        break;
                    default:
                        var commandForm = new CommandForm(arg);
                        commandForm.ShowDialog();
                        break;
                }
            }
            else
            {
                var configForm = new ConfigurationForm();
                configForm.ShowDialog();
            }

        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
