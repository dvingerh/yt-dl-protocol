namespace yt_dl_protocol
{
    partial class ConfigurationForm
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
            this.ProtocolEnabledLabel = new System.Windows.Forms.Label();
            this.ytdlPathLabel = new System.Windows.Forms.Label();
            this.YtDlDownloadPathTextBox = new System.Windows.Forms.TextBox();
            this.BrowseExecutableButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UnregisterButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.BrowseDownloadPathButton = new System.Windows.Forms.Button();
            this.DownloadPathTextBox = new System.Windows.Forms.TextBox();
            this.DownloadPathLabel = new System.Windows.Forms.Label();
            this.ProtocolStatusPictureBox = new System.Windows.Forms.PictureBox();
            this.OffGrayPictureBox = new System.Windows.Forms.PictureBox();
            this.GuideButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolStatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffGrayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProtocolEnabledLabel
            // 
            this.ProtocolEnabledLabel.AutoSize = true;
            this.ProtocolEnabledLabel.Location = new System.Drawing.Point(12, 17);
            this.ProtocolEnabledLabel.Name = "ProtocolEnabledLabel";
            this.ProtocolEnabledLabel.Size = new System.Drawing.Size(126, 20);
            this.ProtocolEnabledLabel.TabIndex = 2;
            this.ProtocolEnabledLabel.Text = "Protocol enabled:";
            // 
            // ytdlPathLabel
            // 
            this.ytdlPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ytdlPathLabel.AutoSize = true;
            this.ytdlPathLabel.Location = new System.Drawing.Point(12, 65);
            this.ytdlPathLabel.Name = "ytdlPathLabel";
            this.ytdlPathLabel.Size = new System.Drawing.Size(118, 20);
            this.ytdlPathLabel.TabIndex = 3;
            this.ytdlPathLabel.Text = "Executable path:";
            // 
            // YtDlDownloadPathTextBox
            // 
            this.YtDlDownloadPathTextBox.Location = new System.Drawing.Point(144, 61);
            this.YtDlDownloadPathTextBox.Name = "YtDlDownloadPathTextBox";
            this.YtDlDownloadPathTextBox.ReadOnly = true;
            this.YtDlDownloadPathTextBox.Size = new System.Drawing.Size(286, 27);
            this.YtDlDownloadPathTextBox.TabIndex = 4;
            // 
            // BrowseExecutableButton
            // 
            this.BrowseExecutableButton.Location = new System.Drawing.Point(399, 62);
            this.BrowseExecutableButton.Name = "BrowseExecutableButton";
            this.BrowseExecutableButton.Size = new System.Drawing.Size(30, 25);
            this.BrowseExecutableButton.TabIndex = 5;
            this.BrowseExecutableButton.Text = "...";
            this.BrowseExecutableButton.UseVisualStyleBackColor = true;
            this.BrowseExecutableButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = global::yt_dl_protocol.Properties.Resources.rules;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(153, 166);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 29);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save settings";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateButton.Image = global::yt_dl_protocol.Properties.Resources.spinner;
            this.UpdateButton.Location = new System.Drawing.Point(16, 166);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(113, 29);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update?";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.CheckForUpdatesButton_Click);
            // 
            // UnregisterButton
            // 
            this.UnregisterButton.Enabled = false;
            this.UnregisterButton.Location = new System.Drawing.Point(315, 12);
            this.UnregisterButton.Name = "UnregisterButton";
            this.UnregisterButton.Size = new System.Drawing.Size(115, 30);
            this.UnregisterButton.TabIndex = 9;
            this.UnregisterButton.Text = "Unregister";
            this.UnregisterButton.UseVisualStyleBackColor = true;
            this.UnregisterButton.Click += new System.EventHandler(this.UnregisterButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RegisterButton.Enabled = false;
            this.RegisterButton.Location = new System.Drawing.Point(178, 12);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(115, 30);
            this.RegisterButton.TabIndex = 10;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // BrowseDownloadPathButton
            // 
            this.BrowseDownloadPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseDownloadPathButton.Location = new System.Drawing.Point(399, 98);
            this.BrowseDownloadPathButton.Name = "BrowseDownloadPathButton";
            this.BrowseDownloadPathButton.Size = new System.Drawing.Size(30, 25);
            this.BrowseDownloadPathButton.TabIndex = 13;
            this.BrowseDownloadPathButton.Text = "...";
            this.BrowseDownloadPathButton.UseVisualStyleBackColor = true;
            this.BrowseDownloadPathButton.Click += new System.EventHandler(this.BrowseDownloadPathButton_Click);
            // 
            // DownloadPathTextBox
            // 
            this.DownloadPathTextBox.Location = new System.Drawing.Point(144, 97);
            this.DownloadPathTextBox.Name = "DownloadPathTextBox";
            this.DownloadPathTextBox.ReadOnly = true;
            this.DownloadPathTextBox.Size = new System.Drawing.Size(286, 27);
            this.DownloadPathTextBox.TabIndex = 12;
            // 
            // DownloadPathLabel
            // 
            this.DownloadPathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DownloadPathLabel.AutoSize = true;
            this.DownloadPathLabel.Location = new System.Drawing.Point(12, 98);
            this.DownloadPathLabel.Name = "DownloadPathLabel";
            this.DownloadPathLabel.Size = new System.Drawing.Size(115, 20);
            this.DownloadPathLabel.TabIndex = 11;
            this.DownloadPathLabel.Text = "Download path:";
            // 
            // ProtocolStatusPictureBox
            // 
            this.ProtocolStatusPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProtocolStatusPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProtocolStatusPictureBox.Image = global::yt_dl_protocol.Properties.Resources.pending;
            this.ProtocolStatusPictureBox.Location = new System.Drawing.Point(144, 13);
            this.ProtocolStatusPictureBox.Name = "ProtocolStatusPictureBox";
            this.ProtocolStatusPictureBox.Size = new System.Drawing.Size(28, 28);
            this.ProtocolStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProtocolStatusPictureBox.TabIndex = 14;
            this.ProtocolStatusPictureBox.TabStop = false;
            // 
            // OffGrayPictureBox
            // 
            this.OffGrayPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OffGrayPictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.OffGrayPictureBox.Location = new System.Drawing.Point(0, 157);
            this.OffGrayPictureBox.Name = "OffGrayPictureBox";
            this.OffGrayPictureBox.Size = new System.Drawing.Size(442, 50);
            this.OffGrayPictureBox.TabIndex = 15;
            this.OffGrayPictureBox.TabStop = false;
            // 
            // GuideButton
            // 
            this.GuideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GuideButton.Image = global::yt_dl_protocol.Properties.Resources.info;
            this.GuideButton.Location = new System.Drawing.Point(305, 166);
            this.GuideButton.Name = "GuideButton";
            this.GuideButton.Size = new System.Drawing.Size(125, 29);
            this.GuideButton.TabIndex = 17;
            this.GuideButton.Text = "Guide";
            this.GuideButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.GuideButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.GuideButton.UseVisualStyleBackColor = true;
            this.GuideButton.Click += new System.EventHandler(this.Guide_Button_Click);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 207);
            this.Controls.Add(this.GuideButton);
            this.Controls.Add(this.ProtocolStatusPictureBox);
            this.Controls.Add(this.BrowseDownloadPathButton);
            this.Controls.Add(this.DownloadPathTextBox);
            this.Controls.Add(this.DownloadPathLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.UnregisterButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BrowseExecutableButton);
            this.Controls.Add(this.YtDlDownloadPathTextBox);
            this.Controls.Add(this.ytdlPathLabel);
            this.Controls.Add(this.ProtocolEnabledLabel);
            this.Controls.Add(this.OffGrayPictureBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "youtube-dl-protocol - configuration";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolStatusPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffGrayPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ProtocolEnabledLabel;
        private System.Windows.Forms.Label ytdlPathLabel;
        private System.Windows.Forms.TextBox YtDlDownloadPathTextBox;
        private System.Windows.Forms.Button BrowseExecutableButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button UnregisterButton;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Button BrowseDownloadPathButton;
        private System.Windows.Forms.TextBox DownloadPathTextBox;
        private System.Windows.Forms.Label DownloadPathLabel;
        private System.Windows.Forms.PictureBox ProtocolStatusPictureBox;
        private System.Windows.Forms.PictureBox OffGrayPictureBox;
        private System.Windows.Forms.Button GuideButton;
    }
}