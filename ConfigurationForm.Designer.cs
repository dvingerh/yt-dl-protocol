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
            this.components = new System.ComponentModel.Container();
            this.ProtocolStatusLabel = new System.Windows.Forms.Label();
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
            this.BookmarkGuideButton = new System.Windows.Forms.Button();
            this.ProtocolToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AutoCloseCommandWindowCheckBox = new System.Windows.Forms.CheckBox();
            this.AdditionalArgsTextBox = new System.Windows.Forms.TextBox();
            this.AdditionalArgsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProtocolStatusPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OffGrayPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProtocolStatusLabel
            // 
            this.ProtocolStatusLabel.AutoSize = true;
            this.ProtocolStatusLabel.Location = new System.Drawing.Point(12, 17);
            this.ProtocolStatusLabel.Name = "ProtocolStatusLabel";
            this.ProtocolStatusLabel.Size = new System.Drawing.Size(110, 20);
            this.ProtocolStatusLabel.TabIndex = 0;
            this.ProtocolStatusLabel.Text = "Protocol status:";
            this.ProtocolToolTip.SetToolTip(this.ProtocolStatusLabel, "You need to set up the path settings before the protocol can be registered.");
            // 
            // ytdlPathLabel
            // 
            this.ytdlPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ytdlPathLabel.AutoSize = true;
            this.ytdlPathLabel.Location = new System.Drawing.Point(12, 65);
            this.ytdlPathLabel.Name = "ytdlPathLabel";
            this.ytdlPathLabel.Size = new System.Drawing.Size(118, 20);
            this.ytdlPathLabel.TabIndex = 3;
            this.ytdlPathLabel.Text = "Executable path:";
            // 
            // YtDlDownloadPathTextBox
            // 
            this.YtDlDownloadPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.YtDlDownloadPathTextBox.Location = new System.Drawing.Point(144, 61);
            this.YtDlDownloadPathTextBox.Name = "YtDlDownloadPathTextBox";
            this.YtDlDownloadPathTextBox.ReadOnly = true;
            this.YtDlDownloadPathTextBox.Size = new System.Drawing.Size(426, 27);
            this.YtDlDownloadPathTextBox.TabIndex = 4;
            // 
            // BrowseExecutableButton
            // 
            this.BrowseExecutableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseExecutableButton.Location = new System.Drawing.Point(539, 62);
            this.BrowseExecutableButton.Name = "BrowseExecutableButton";
            this.BrowseExecutableButton.Size = new System.Drawing.Size(30, 25);
            this.BrowseExecutableButton.TabIndex = 5;
            this.BrowseExecutableButton.Text = "...";
            this.BrowseExecutableButton.UseVisualStyleBackColor = true;
            this.BrowseExecutableButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.Enabled = false;
            this.SaveButton.Image = global::yt_dl_protocol.Properties.Resources.rules;
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveButton.Location = new System.Drawing.Point(12, 227);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 35);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save Settings";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateButton.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Image = global::yt_dl_protocol.Properties.Resources.update;
            this.UpdateButton.Location = new System.Drawing.Point(510, 62);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(30, 25);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Visible = false;
            this.UpdateButton.Click += new System.EventHandler(this.CheckForUpdatesButton_Click);
            // 
            // UnregisterButton
            // 
            this.UnregisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnregisterButton.Enabled = false;
            this.UnregisterButton.Location = new System.Drawing.Point(364, 12);
            this.UnregisterButton.Name = "UnregisterButton";
            this.UnregisterButton.Size = new System.Drawing.Size(170, 30);
            this.UnregisterButton.TabIndex = 2;
            this.UnregisterButton.Text = "Unregister";
            this.UnregisterButton.UseVisualStyleBackColor = true;
            this.UnregisterButton.Click += new System.EventHandler(this.UnregisterButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Enabled = false;
            this.RegisterButton.Location = new System.Drawing.Point(144, 12);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(170, 30);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // BrowseDownloadPathButton
            // 
            this.BrowseDownloadPathButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseDownloadPathButton.Location = new System.Drawing.Point(539, 95);
            this.BrowseDownloadPathButton.Name = "BrowseDownloadPathButton";
            this.BrowseDownloadPathButton.Size = new System.Drawing.Size(30, 25);
            this.BrowseDownloadPathButton.TabIndex = 8;
            this.BrowseDownloadPathButton.Text = "...";
            this.BrowseDownloadPathButton.UseVisualStyleBackColor = true;
            this.BrowseDownloadPathButton.Click += new System.EventHandler(this.BrowseDownloadPathButton_Click);
            // 
            // DownloadPathTextBox
            // 
            this.DownloadPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadPathTextBox.Location = new System.Drawing.Point(144, 94);
            this.DownloadPathTextBox.Name = "DownloadPathTextBox";
            this.DownloadPathTextBox.ReadOnly = true;
            this.DownloadPathTextBox.Size = new System.Drawing.Size(426, 27);
            this.DownloadPathTextBox.TabIndex = 7;
            // 
            // DownloadPathLabel
            // 
            this.DownloadPathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.DownloadPathLabel.AutoSize = true;
            this.DownloadPathLabel.Location = new System.Drawing.Point(12, 95);
            this.DownloadPathLabel.Name = "DownloadPathLabel";
            this.DownloadPathLabel.Size = new System.Drawing.Size(115, 20);
            this.DownloadPathLabel.TabIndex = 6;
            this.DownloadPathLabel.Text = "Download path:";
            // 
            // ProtocolStatusPictureBox
            // 
            this.ProtocolStatusPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProtocolStatusPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ProtocolStatusPictureBox.Image = global::yt_dl_protocol.Properties.Resources.pending;
            this.ProtocolStatusPictureBox.Location = new System.Drawing.Point(540, 13);
            this.ProtocolStatusPictureBox.Name = "ProtocolStatusPictureBox";
            this.ProtocolStatusPictureBox.Size = new System.Drawing.Size(28, 28);
            this.ProtocolStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ProtocolStatusPictureBox.TabIndex = 14;
            this.ProtocolStatusPictureBox.TabStop = false;
            this.ProtocolToolTip.SetToolTip(this.ProtocolStatusPictureBox, "You need to set up the required paths below before you can register the protocol." +
        "");
            this.ProtocolStatusPictureBox.BackgroundImageChanged += new System.EventHandler(this.ProtocolStatusPictureBox_BackgroundImageChanged);
            // 
            // OffGrayPictureBox
            // 
            this.OffGrayPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OffGrayPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OffGrayPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OffGrayPictureBox.Location = new System.Drawing.Point(-1, 215);
            this.OffGrayPictureBox.Name = "OffGrayPictureBox";
            this.OffGrayPictureBox.Size = new System.Drawing.Size(584, 60);
            this.OffGrayPictureBox.TabIndex = 15;
            this.OffGrayPictureBox.TabStop = false;
            // 
            // BookmarkGuideButton
            // 
            this.BookmarkGuideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BookmarkGuideButton.Image = global::yt_dl_protocol.Properties.Resources.info;
            this.BookmarkGuideButton.Location = new System.Drawing.Point(420, 227);
            this.BookmarkGuideButton.Name = "BookmarkGuideButton";
            this.BookmarkGuideButton.Size = new System.Drawing.Size(150, 35);
            this.BookmarkGuideButton.TabIndex = 11;
            this.BookmarkGuideButton.Text = "Bookmark Guide";
            this.BookmarkGuideButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BookmarkGuideButton.UseVisualStyleBackColor = true;
            this.BookmarkGuideButton.Click += new System.EventHandler(this.Guide_Button_Click);
            // 
            // ProtocolToolTip
            // 
            this.ProtocolToolTip.AutomaticDelay = 0;
            this.ProtocolToolTip.BackColor = System.Drawing.Color.White;
            this.ProtocolToolTip.IsBalloon = true;
            this.ProtocolToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ProtocolToolTip.ToolTipTitle = "Registering the protocol";
            this.ProtocolToolTip.UseAnimation = false;
            this.ProtocolToolTip.UseFading = false;
            // 
            // AutoCloseCommandWindowCheckBox
            // 
            this.AutoCloseCommandWindowCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoCloseCommandWindowCheckBox.AutoSize = true;
            this.AutoCloseCommandWindowCheckBox.Location = new System.Drawing.Point(16, 171);
            this.AutoCloseCommandWindowCheckBox.Name = "AutoCloseCommandWindowCheckBox";
            this.AutoCloseCommandWindowCheckBox.Size = new System.Drawing.Size(500, 24);
            this.AutoCloseCommandWindowCheckBox.TabIndex = 9;
            this.AutoCloseCommandWindowCheckBox.Text = "Automatically close the command window when download is finished?";
            this.AutoCloseCommandWindowCheckBox.UseVisualStyleBackColor = true;
            // 
            // AdditionalArgsTextBox
            // 
            this.AdditionalArgsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionalArgsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdditionalArgsTextBox.Location = new System.Drawing.Point(144, 127);
            this.AdditionalArgsTextBox.Name = "AdditionalArgsTextBox";
            this.AdditionalArgsTextBox.Size = new System.Drawing.Size(426, 27);
            this.AdditionalArgsTextBox.TabIndex = 17;
            // 
            // AdditionalArgsLabel
            // 
            this.AdditionalArgsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AdditionalArgsLabel.AutoSize = true;
            this.AdditionalArgsLabel.Location = new System.Drawing.Point(12, 128);
            this.AdditionalArgsLabel.Name = "AdditionalArgsLabel";
            this.AdditionalArgsLabel.Size = new System.Drawing.Size(114, 20);
            this.AdditionalArgsLabel.TabIndex = 16;
            this.AdditionalArgsLabel.Text = "Additional args:";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(582, 274);
            this.Controls.Add(this.AdditionalArgsTextBox);
            this.Controls.Add(this.AdditionalArgsLabel);
            this.Controls.Add(this.AutoCloseCommandWindowCheckBox);
            this.Controls.Add(this.BookmarkGuideButton);
            this.Controls.Add(this.ProtocolStatusPictureBox);
            this.Controls.Add(this.BrowseDownloadPathButton);
            this.Controls.Add(this.DownloadPathTextBox);
            this.Controls.Add(this.DownloadPathLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.UnregisterButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.BrowseExecutableButton);
            this.Controls.Add(this.ytdlPathLabel);
            this.Controls.Add(this.ProtocolStatusLabel);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.OffGrayPictureBox);
            this.Controls.Add(this.YtDlDownloadPathTextBox);
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
        private System.Windows.Forms.Label ProtocolStatusLabel;
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
        private System.Windows.Forms.Button BookmarkGuideButton;
        private System.Windows.Forms.ToolTip ProtocolToolTip;
        private System.Windows.Forms.CheckBox AutoCloseCommandWindowCheckBox;
        private System.Windows.Forms.TextBox AdditionalArgsTextBox;
        private System.Windows.Forms.Label AdditionalArgsLabel;
    }
}