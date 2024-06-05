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
            YtDlDownloadPathTextBox.Text = Settings.Default.ytdl_path;
            DownloadPathTextBox.Text = Settings.Default.download_path;
            AdditionalArgsTextBox.Text = Settings.Default.additional_args;

            AutoCloseCommandWindowCheckBox.Checked = Settings.Default.autoclose_on_finish;
            UpdateCanRegisterState();
        }

        private void UpdateCanRegisterState()
        {
            bool isRegistered = Utils.IsProtocolRegistered(Settings.Default.protocol_ytdl);
            bool isValidYtDlPath = File.Exists(Settings.Default.ytdl_path) || File.Exists(YtDlDownloadPathTextBox.Text);
            bool isValidDlPath = Directory.Exists(Settings.Default.download_path) || Directory.Exists(DownloadPathTextBox.Text);

            bool canRegister = isValidYtDlPath && isValidDlPath;

            UpdateButton.Enabled = isValidYtDlPath;

            if (canRegister)
            {
                SaveButton.Enabled = canRegister;
                //RegisterButton.Enabled = !isRegistered;
                //UnregisterButton.Enabled = isRegistered;

                ProtocolStatusPictureBox.Image = isRegistered ? Resources.success : Resources.error;
                ProtocolStatusPictureBox.Cursor = Cursors.Default;
                ProtocolStatusLabel.Cursor = Cursors.Default;
            }
            else
            {
                ProtocolStatusPictureBox.Image = Resources.pending;
                ProtocolStatusPictureBox.Cursor = Cursors.Help;
                ProtocolStatusLabel.Cursor = Cursors.Help;
            }
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
            }
            else
            {
                MessageBox.Show("The provided file is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateButton.Enabled = false;
            }

            UpdateCanRegisterState();
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
            Settings.Default.autoclose_on_finish = AutoCloseCommandWindowCheckBox.Checked;
            Settings.Default.additional_args = AdditionalArgsTextBox.Text;
            Settings.Default.Save();
            Settings.Default.Reload();
            UpdateCanRegisterState();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(YtDlDownloadPathTextBox.Text) || !Directory.Exists(DownloadPathTextBox.Text))
                MessageBox.Show("The settings could not be saved due to one or more invalid paths.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                SaveSettings();
                MessageBox.Show("The settings have been saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            bool isRegistered = Utils.IsProtocolRegistered(Settings.Default.protocol_ytdl);
            RegisterButton.Enabled = !isRegistered;
            UnregisterButton.Enabled = isRegistered;
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
            }
            else
            {
                MessageBox.Show("The provided directory is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateCanRegisterState();
        }

        private void Guide_Button_Click(object sender, EventArgs e)
        {
            new BookmarkForm().ShowDialog();  
        }

        private void ProtocolStatusPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (ProtocolStatusPictureBox.BackgroundImage == Properties.Resources.pending)
            {
                if (File.Exists(Settings.Default.ytdl_path))
                {
                    ProtocolStatusPictureBox.Cursor = Cursors.Default;
                    ProtocolStatusLabel.Cursor = Cursors.Default;
                }
                else
                {
                    ProtocolStatusPictureBox.Cursor = Cursors.Help;
                    ProtocolStatusLabel.Cursor = Cursors.Help;
                }
            }
            else
            {
                ProtocolStatusPictureBox.Cursor = Cursors.Default;
                ProtocolStatusLabel.Cursor = Cursors.Default;
            }
        }
    }
}
