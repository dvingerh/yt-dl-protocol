using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace yt_dl_protocol
{
    public partial class BookmarkForm : Form
    {
        public BookmarkForm()
        {
            InitializeComponent();
        }
        // Define Gruvbox colors
        private Color backgroundColor = Color.FromArgb(39, 48, 43);
        private Color foregroundColor = Color.FromArgb(235, 219, 178);
        private Color keywordColor = Color.FromArgb(250, 189, 47);
        private Color functionColor = Color.FromArgb(235, 219, 178);
        private Color variableColor = Color.FromArgb(131, 165, 152);
        private Color objectMethodColor = Color.FromArgb(142, 192, 124);
        private Color stringColor = Color.FromArgb(184, 187, 38);

        private string jsCode = "javascript:(function(){window.open('ytdl://'+ encodeURIComponent(window.location.href),'_self');})();";

        private void Document_MouseDown(object sender, HtmlElementEventArgs e)
        {
            e.ReturnValue = false;
        }

        private void InstructionForm_Load(object sender, EventArgs e)
        {
            ApplySyntaxHighlighting();
        }

        private void ApplySyntaxHighlighting()
        {
            int selectionStart = BookmarkletRichTextBox.SelectionStart;
            int selectionLength = BookmarkletRichTextBox.SelectionLength;

            BookmarkletRichTextBox.SelectAll();
            BookmarkletRichTextBox.SelectionColor = foregroundColor;

            HighlightPattern(@"\b(javascript|function|var)\b", keywordColor);

            HighlightPattern(@"\b(window|location|href|open)\b", objectMethodColor);

            HighlightPattern(@"'[^']*'", stringColor);

            BookmarkletRichTextBox.SelectionStart = selectionStart;
            BookmarkletRichTextBox.SelectionLength = selectionLength;
            BookmarkletRichTextBox.SelectionColor = foregroundColor;

        }

        private void HighlightPattern(string pattern, Color color)
        {
            Regex regex = new Regex(pattern, RegexOptions.Multiline);
            MatchCollection matches = regex.Matches(BookmarkletRichTextBox.Text);

            foreach (Match match in matches)
            {
                BookmarkletRichTextBox.Select(match.Index, match.Length);
                BookmarkletRichTextBox.SelectionColor = color;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            ApplySyntaxHighlighting();
        }

        private void BookmarkletRichTextBox_MouseDown(object sender, MouseEventArgs e)
        {
            BookmarkletRichTextBox.SelectAll();
        }

        private void BookmarkletRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void BookmarkletRichTextBox_MouseLeave(object sender, EventArgs e)
        {
            BookmarkletRichTextBox.DeselectAll();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(jsCode);
        }
    }
}
