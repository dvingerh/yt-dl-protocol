namespace yt_dl_protocol
{
    partial class CommandForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandForm));
            this.CommandOutputTextBox = new System.Windows.Forms.TextBox();
            this.StopOkButton = new System.Windows.Forms.Button();
            this.DownloadProgressBar = new ProgressBarSample.TextProgressBar();
            this.SuspendLayout();
            // 
            // CommandOutputTextBox
            // 
            this.CommandOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandOutputTextBox.BackColor = System.Drawing.Color.White;
            this.CommandOutputTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandOutputTextBox.Location = new System.Drawing.Point(15, 15);
            this.CommandOutputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CommandOutputTextBox.MaxLength = 9999999;
            this.CommandOutputTextBox.Multiline = true;
            this.CommandOutputTextBox.Name = "CommandOutputTextBox";
            this.CommandOutputTextBox.ReadOnly = true;
            this.CommandOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CommandOutputTextBox.Size = new System.Drawing.Size(752, 340);
            this.CommandOutputTextBox.TabIndex = 0;
            this.CommandOutputTextBox.WordWrap = false;
            // 
            // StopOkButton
            // 
            this.StopOkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopOkButton.Image = global::yt_dl_protocol.Properties.Resources.error;
            this.StopOkButton.Location = new System.Drawing.Point(647, 362);
            this.StopOkButton.Name = "StopOkButton";
            this.StopOkButton.Size = new System.Drawing.Size(120, 29);
            this.StopOkButton.TabIndex = 3;
            this.StopOkButton.Text = "Stop";
            this.StopOkButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StopOkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StopOkButton.UseVisualStyleBackColor = true;
            this.StopOkButton.Click += new System.EventHandler(this.StopOkButon_Click);
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadProgressBar.CustomText = "";
            this.DownloadProgressBar.Location = new System.Drawing.Point(15, 363);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.ProgressColor = System.Drawing.Color.YellowGreen;
            this.DownloadProgressBar.Size = new System.Drawing.Size(626, 27);
            this.DownloadProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.DownloadProgressBar.TabIndex = 17;
            this.DownloadProgressBar.TextColor = System.Drawing.Color.Black;
            this.DownloadProgressBar.TextFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadProgressBar.VisualMode = ProgressBarSample.ProgressBarDisplayMode.Percentage;
            // 
            // CommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.DownloadProgressBar);
            this.Controls.Add(this.StopOkButton);
            this.Controls.Add(this.CommandOutputTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CommandForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "youtube-dl-protocol - pending";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CommandOutputTextBox;
        private System.Windows.Forms.Button StopOkButton;
        private ProgressBarSample.TextProgressBar DownloadProgressBar;
    }
}

