namespace yt_dl_protocol
{
    partial class BookmarkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarkForm));
            this.BookmarkletRichTextBox = new System.Windows.Forms.RichTextBox();
            this.CopyContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InstructionsLabel = new System.Windows.Forms.Label();
            this.CopyContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BookmarkletRichTextBox
            // 
            this.BookmarkletRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(48)))), ((int)(((byte)(43)))));
            this.BookmarkletRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BookmarkletRichTextBox.ContextMenuStrip = this.CopyContextMenu;
            this.BookmarkletRichTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BookmarkletRichTextBox.DetectUrls = false;
            this.BookmarkletRichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.BookmarkletRichTextBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.BookmarkletRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(219)))), ((int)(((byte)(187)))));
            this.BookmarkletRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.BookmarkletRichTextBox.Name = "BookmarkletRichTextBox";
            this.BookmarkletRichTextBox.ReadOnly = true;
            this.BookmarkletRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.BookmarkletRichTextBox.Size = new System.Drawing.Size(372, 108);
            this.BookmarkletRichTextBox.TabIndex = 0;
            this.BookmarkletRichTextBox.Text = "javascript:(function(){\nvar currentURL=window.location.href;\nvar ytdlURL=\'ytdl://" +
    "\'+currentURL;\nwindow.open(ytdlURL,\'_self\');\n})();";
            this.BookmarkletRichTextBox.WordWrap = false;
            this.BookmarkletRichTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.BookmarkletRichTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BookmarkletRichTextBox_KeyPress);
            this.BookmarkletRichTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BookmarkletRichTextBox_MouseDown);
            this.BookmarkletRichTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BookmarkletRichTextBox_MouseDown);
            this.BookmarkletRichTextBox.MouseLeave += new System.EventHandler(this.BookmarkletRichTextBox_MouseLeave);
            this.BookmarkletRichTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BookmarkletRichTextBox_MouseDown);
            // 
            // CopyContextMenu
            // 
            this.CopyContextMenu.BackColor = System.Drawing.Color.White;
            this.CopyContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CopyContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem});
            this.CopyContextMenu.Name = "CopyContextMenu";
            this.CopyContextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.CopyContextMenu.Size = new System.Drawing.Size(113, 28);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.CopyToolStripMenuItem.Text = "Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // InstructionsLabel
            // 
            this.InstructionsLabel.AutoEllipsis = true;
            this.InstructionsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstructionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionsLabel.Location = new System.Drawing.Point(0, 108);
            this.InstructionsLabel.Margin = new System.Windows.Forms.Padding(4);
            this.InstructionsLabel.Name = "InstructionsLabel";
            this.InstructionsLabel.Size = new System.Drawing.Size(372, 106);
            this.InstructionsLabel.TabIndex = 1;
            this.InstructionsLabel.Text = "Copy the above JS code and save it as a bookmarklet in your web browser. Whenever" +
    " you click it on a site with supported media, the file(s) will be downloaded aut" +
    "omatically.";
            this.InstructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookmarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 214);
            this.Controls.Add(this.InstructionsLabel);
            this.Controls.Add(this.BookmarkletRichTextBox);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookmarkForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "youtube-dl-protocol - bookmark guide";
            this.Load += new System.EventHandler(this.InstructionForm_Load);
            this.CopyContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox BookmarkletRichTextBox;
        private System.Windows.Forms.Label InstructionsLabel;
        private System.Windows.Forms.ContextMenuStrip CopyContextMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
    }
}