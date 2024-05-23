namespace yt_dl_protocol
{
    partial class InstructionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructionForm));
            this.BookmarkletRichTextBox = new System.Windows.Forms.RichTextBox();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BookmarkletRichTextBox
            // 
            this.BookmarkletRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))));
            this.BookmarkletRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookmarkletRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookmarkletRichTextBox.DetectUrls = false;
            this.BookmarkletRichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookmarkletRichTextBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookmarkletRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.BookmarkletRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.BookmarkletRichTextBox.Name = "BookmarkletRichTextBox";
            this.BookmarkletRichTextBox.ReadOnly = true;
            this.BookmarkletRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BookmarkletRichTextBox.ShowSelectionMargin = true;
            this.BookmarkletRichTextBox.Size = new System.Drawing.Size(442, 132);
            this.BookmarkletRichTextBox.TabIndex = 0;
            this.BookmarkletRichTextBox.Text = "javascript:(function(){\n    var currentURL=window.location.href;\n    var ytdlURL=" +
    "\'ytdl://\'+currentURL;\n    window.open(ytdlURL,\'_self\');\n})();";
            this.BookmarkletRichTextBox.WordWrap = false;
            this.BookmarkletRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.BookmarkletRichTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookmarkletRichTextBox_MouseDown);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoEllipsis = true;
            this.InstructionsLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InstructionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(0, 139);
            this.InstructionsLabel.Margin = new System.Windows.Forms.Padding(4);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(442, 68);
            this.InstructionsLabel.TabIndex = 1;
            this.InstructionsLabel.Text = "Copy the above JS code and save it as a bookmark in your favorite browser. Whenev" +
    "er you click it on a site with supported media, the file(s) will be downloaded a" +
    "utomatically.";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 207);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.BookmarkletRichTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 254);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(460, 254);
            this.Name = "InstructionForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "youtube-dl-protocol - instructions";
            this.Load += new System.EventHandler(this.InstructionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox BookmarkletRichTextBox;
        private System.Windows.Forms.Label InstructionsLabel;
    }
}