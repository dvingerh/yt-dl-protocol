using System;
using System.IO;
using System.Windows.Forms;
using yt_dl_protocol.Properties;

namespace yt_dl_protocol
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            bool isRegistered = Utils.IsProtocolRegistered(Settings.Default.protocol_ytdl);
            bool isValidYtDlPath = File.Exists(Settings.Default.ytdl_path);

            if (!isValidYtDlPath)
            {
                RegisterButton.Enabled = false;
                UnregisterButton.Enabled = false;
            }
            else if (isRegistered)
            {
                RegisterButton.Enabled = false;
                UnregisterButton.Enabled = true;
            }
            else
            {
                RegisterButton.Enabled = true;
                UnregisterButton.Enabled = false;
            }

            UpdateButton.Enabled = isValidYtDlPath;
            YtDlDownloadPathTextBox.Text = Settings.Default.ytdl_path;

            DownloadPathTextBox.Text = Settings.Default.download_path;

            ProtocolStatusPictureBox.Image = isRegistered ? Resources.success : Resources.error;
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Executable Files|*.exe",
                Title = "Select youtube-dl or yt-dlp executable",
                Multiselect = false,
                CheckFileExists = true,
                CheckPathExists = true
            };
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK && File.Exists(openFileDialog.FileName))
            {
                YtDlDownloadPathTextBox.Text = openFileDialog.FileName;
                Settings.Default.ytdl_path = YtDlDownloadPathTextBox.Text;
                UpdateButton.Enabled = true;
                SaveSettings();
            }
            else
            {
                MessageBox.Show("The provided file is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateButton.Enabled = false;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            HandleProtocolRegistering(true);
        }

        private void UnregisterButton_Click(object sender, EventArgs e)
        {
            HandleProtocolRegistering(false);
        }

        private void HandleProtocolRegistering(bool register)
        {
            if (register)
            {
                Settings.Default.protocol_registered = Utils.RegisterURLProtocol("ytdl", Application.ExecutablePath, "youtube-dl-protocol-handler");
                UnregisterButton.Enabled = true;
                RegisterButton.Enabled = false;
            }
            else
            {
                Settings.Default.protocol_registered = Utils.UnregisterURLProtocol("ytdl");
                UnregisterButton.Enabled = false;
                RegisterButton.Enabled = true;
            }
            bool isRegistered = Utils.IsProtocolRegistered(Settings.Default.protocol_ytdl);
            ProtocolStatusPictureBox.Image = isRegistered ? Resources.success : Resources.error;
            SaveSettings();
        }

        private void SaveSettings()
        {
            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(YtDlDownloadPathTextBox.Text) || !Directory.Exists(DownloadPathTextBox.Text))
            {
                MessageBox.Show("The settings could not be saved due to one or more invalid paths.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                SaveSettings();
                Close();
            }
        }

        private void CheckForUpdatesButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            var form = new CommandForm("-U");
            form.ShowDialog();
            Enabled = true;
        }

        private void BrowseDownloadPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog selectFolderDialog = new FolderBrowserDialog
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                Description = "Select a destination",
                ShowNewFolderButton = true,
            };
            DialogResult result = selectFolderDialog.ShowDialog();
            if (result == DialogResult.OK && Directory.Exists(selectFolderDialog.SelectedPath))
            {
                DownloadPathTextBox.Text = selectFolderDialog.SelectedPath;
                Settings.Default.download_path = DownloadPathTextBox.Text;
                SaveButton.Enabled = true;
                SaveSettings();
            }
            else
            {
                MessageBox.Show("The provided directory is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SaveButton.Enabled = false;
            }
        }

        private void Guide_Button_Click(object sender, EventArgs e)
        {
            new InstructionForm().ShowDialog();  
        }
    }
}
