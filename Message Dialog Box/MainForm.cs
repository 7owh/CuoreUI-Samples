using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CuoreUI.Controls;

namespace Message_Dialog_Box
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UpdateCodeBlockBasedOnCodeString();
        }

        static string[] codeString = new string[] { "cuiMessageDialog1.ShowDialog(", "this,", "\"This is the description!\",", "\"Title\",", "MessageBoxButtons.OK);" };

        static class CodeInsideCodeBlock
        {
            public static string description
            {
                get
                {
                    return codeString[2].Substring(1, codeString[2].Length - 3);
                }
                set
                {
                    codeString[2] = $"\"{value}\",";
                }
            }

            public static string title
            {
                get
                {
                    return codeString[3].Substring(1, codeString[3].Length - 3);
                }
                set
                {
                    codeString[3] = $"\"{value}\",";
                }
            }

            public static string messageBoxButtons
            {
                get
                {
                    return codeString[3].Substring(1, codeString[3].Length - 3);
                }
                set
                {
                    codeString[4] = $"MessageBoxButtons.{value});";
                }
            }
        }

        void UpdateCodeBlockBasedOnCodeString()
        {
            codeblockDescriptionLabel.Content = codeString[2];
            codeblockTitleLabel.Content = codeString[3];
            codeblockMessageBoxButtonsLabel.Content = codeString[4];
        }

        private void dialogRoundingSlider_ValueChanged(object sender, EventArgs e)
        {
            cuiMessageDialog1.Rounding = (int)(dialogRoundingSlider.Value * 0.1d);
            cuiLabel2.Content = $"{cuiMessageDialog1.Rounding}px";
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            cuiMessageDialog1.ShowDialog(
                this,
                Regex.Unescape(CodeInsideCodeBlock.description),
                Regex.Unescape(CodeInsideCodeBlock.title),
                messageBoxButtons);
        }

        private void cuiTextBox1_ContentChanged(object sender, EventArgs e)
        {
            CodeInsideCodeBlock.title = Regex.Escape(((cuiTextBox)sender).Content);
            UpdateCodeBlockBasedOnCodeString();
        }

        private void cuiTextBox2_ContentChanged(object sender, EventArgs e)
        {
            CodeInsideCodeBlock.description = Regex.Escape(((cuiTextBox)sender).Content);
            UpdateCodeBlockBasedOnCodeString();
        }

        MessageBoxButtons messageBoxButtons = MessageBoxButtons.OK;

        private void progressStateButton_Click(object sender, EventArgs e)
        {
            messageBoxButtons = MessageBoxButtons.OK;
            string s = ((cuiButtonGroup)sender).Content;

            if (s.Length > 2)
            {
                messageBoxButtons = s[2] == 's' ? MessageBoxButtons.YesNo : MessageBoxButtons.OKCancel;
            }

            cuiLabel10.Content = s;
            CodeInsideCodeBlock.messageBoxButtons = s;
            UpdateCodeBlockBasedOnCodeString();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            string a = Regex.Unescape(string.Join("\n    ", codeString));
            Clipboard.SetText(a);
        }
    }
}
