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
            this.EndButton = new System.Windows.Forms.Button();
            this.CommandProgressBar = new System.Windows.Forms.ProgressBar();
            this.CommandProgressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CommandOutputTextBox
            // 
            this.CommandOutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandOutputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CommandOutputTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommandOutputTextBox.Location = new System.Drawing.Point(15, 15);
            this.CommandOutputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CommandOutputTextBox.Multiline = true;
            this.CommandOutputTextBox.Name = "CommandOutputTextBox";
            this.CommandOutputTextBox.ReadOnly = true;
            this.CommandOutputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.CommandOutputTextBox.Size = new System.Drawing.Size(752, 340);
            this.CommandOutputTextBox.TabIndex = 0;
            this.CommandOutputTextBox.WordWrap = false;
            // 
            // EndButton
            // 
            this.EndButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndButton.Image = global::yt_dl_protocol.Properties.Resources.error;
            this.EndButton.Location = new System.Drawing.Point(647, 362);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(120, 29);
            this.EndButton.TabIndex = 1;
            this.EndButton.Text = "Kill Process";
            this.EndButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EndButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // CommandProgressBar
            // 
            this.CommandProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandProgressBar.Location = new System.Drawing.Point(15, 365);
            this.CommandProgressBar.Name = "CommandProgressBar";
            this.CommandProgressBar.Size = new System.Drawing.Size(567, 23);
            this.CommandProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.CommandProgressBar.TabIndex = 0;
            // 
            // CommandProgressLabel
            // 
            this.CommandProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CommandProgressLabel.Location = new System.Drawing.Point(588, 365);
            this.CommandProgressLabel.Name = "CommandProgressLabel";
            this.CommandProgressLabel.Size = new System.Drawing.Size(53, 16);
            this.CommandProgressLabel.TabIndex = 2;
            this.CommandProgressLabel.Text = "~%";
            this.CommandProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CommandForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(782, 403);
            this.Controls.Add(this.CommandProgressLabel);
            this.Controls.Add(this.CommandProgressBar);
            this.Controls.Add(this.EndButton);
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
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.ProgressBar CommandProgressBar;
        private System.Windows.Forms.Label CommandProgressLabel;
    }
}

