using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using yt_dl_protocol.Properties;

namespace yt_dl_protocol
{
    public partial class CommandForm : Form
    {
        public string url;
        public string outputPath;
        public string ytdlPath = Settings.Default.ytdl_path;
        public bool isFinished = false;
        public Process ytdlProcess;
        public CommandForm(string url)
        {
            InitializeComponent();
            this.url = url;
            Shown += CommandForm_Shown;
        }

        private void CommandForm_Shown(object sender, EventArgs e)
        {
            Task.Run(() => BeginCommand(url)); // Start download on a background thread
        }


        private async void BeginCommand(string protocolUrl)
        {

            // Remove the custom "ytdl://" scheme from the URL
            string desktopPath = Directory.Exists(Settings.Default.download_path) ? Settings.Default.download_path : Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string command = "";
            string nameCommand = $" --quiet --ignore-errors --no-warnings --get-filename {protocolUrl} -o \"{desktopPath}\\%(title)s.%(ext)s\"";
            //string outputPath = await Task.Run(() => ExtractFilePath(nameCommand));
            // Construct the command ensuring the URL is enclosed in quotes to handle any special characters
            if (protocolUrl == "-U")
            {
                command = $" -U";
            }
            else
            {
                command = $" --newline {protocolUrl} -o \"{desktopPath}\\%(title)s.%(ext)s\"";

            }
            Invoke(new Action(() =>
            {
                CommandOutputTextBox.AppendText(Path.GetFileName(Settings.Default.ytdl_path) + command + Environment.NewLine + Environment.NewLine);
            }));

            using (ytdlProcess = new Process())
            {
                ytdlProcess.StartInfo.FileName = $"{ytdlPath}";
                ytdlProcess.StartInfo.Arguments = $" {command} ";
                ytdlProcess.StartInfo.UseShellExecute = false;
                ytdlProcess.StartInfo.RedirectStandardOutput = true;
                ytdlProcess.StartInfo.RedirectStandardError = true;
                ytdlProcess.StartInfo.CreateNoWindow = true;

                // Output and error handling
                ytdlProcess.OutputDataReceived += (sender, e) =>
                {
                    if (e.Data != null)
                    {
                        Invoke(new Action(() =>
                        {
                            CommandOutputTextBox.AppendText(e.Data + Environment.NewLine);
                            decimal? progress = ExtractProgress(e.Data);
                            if (progress.HasValue && progress != -1)
                            {
                                CommandProgressBar.Value = (int)Math.Round(progress.Value);
                                CommandProgressLabel.Text = $"{progress.Value}%";
                                CommandProgressBar.Style = ProgressBarStyle.Continuous;
                                Text = $"youtube-dl-protocol - downloaded {progress.Value}%";
                            }
                            else
                            {
                                CommandProgressBar.Style = ProgressBarStyle.Marquee;
                                CommandProgressBar.MarqueeAnimationSpeed = 1;
                                Text = $"youtube-dl-protocol - processing files...";
                            }
                        }));
                    }
                };

                ytdlProcess.ErrorDataReceived += (sender, e) =>
                {
                    if (e.Data != null)
                    {
                        Invoke(new Action(() =>
                        {
                            CommandOutputTextBox.AppendText("Error: " + e.Data + Environment.NewLine);
                        }));
                    }
                };

                // Start process and begin asynchronously reading output
                ytdlProcess.Start();
                ytdlProcess.BeginOutputReadLine();
                ytdlProcess.BeginErrorReadLine();

                ytdlProcess.WaitForExit();  // Wait for the process to complete

                Invoke(new Action(() =>
                {
                    CommandOutputTextBox.AppendText(Environment.NewLine + Environment.NewLine + "The command has has finished running.");
                    if (command == "-U")
                    {
                        CommandOutputTextBox.AppendText(Environment.NewLine + "Your file has been saved to the following location:");
                        CommandOutputTextBox.AppendText(Environment.NewLine + $"{outputPath}");
                    }
                    ControlBox = true;  // Enable the Close button after the process ends
                    isFinished = true;
                    EndButton.Enabled = false;
                    CommandProgressLabel.Text = "100%";
                    CommandProgressBar.Style = ProgressBarStyle.Continuous;
                                Text = $"youtube-dl-protocol - done";
                    CommandProgressBar.Value = 100;
                }));
            }
            if (Properties.Settings.Default.autoclose_on_finish)
            {
                await Task.Delay(2000);
                Close();
            }
        }

    private decimal? ExtractProgress(string input)
        {
            string pattern = @"\[download\]\s+([\d.,]+)%\s+of";

            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                string progress = match.Groups[1].Value;

                // Replace commas with dots if necessary
                progress = progress.Replace(',', '.');

                // Try to parse the sanitized string to a float
                if (decimal.TryParse(progress, NumberStyles.Float, CultureInfo.InvariantCulture, out decimal progressValue))
                {
                    return progressValue;
                }
            }

            return -1;
        }


        private void EndButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in Process.GetProcessesByName(Path.GetFileName(Settings.Default.ytdl_path)))
                {
                    item.Kill(); // Eh? Maybe zombie processes by improperly handing their shut down
                }
                //Environment.Exit(1);
            }
            catch (Exception)
            {

                Invoke(new Action(() =>
                {
                    CommandOutputTextBox.AppendText(Environment.NewLine + Environment.NewLine + "The process could not be killed: " + e.ToString());
                }));
            }
            finally
            {
                ControlBox = true;
            }
        }
    }
}