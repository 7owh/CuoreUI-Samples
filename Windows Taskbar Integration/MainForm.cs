using System;
using System.Drawing;
using System.Windows.Forms;
using CuoreUI.Components;
using CuoreUI.Controls;
using Windows_Taskbar_Integration.Properties;

namespace Windows_Taskbar_Integration
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void stateValueSlider_ValueChanged(object sender, EventArgs e)
        {
            cuiTaskbarStateController1.ProgressValue = (int)((cuiSlider)sender).Value;
            cuiLabel2.Content = $"{cuiTaskbarStateController1.ProgressValue}%";

            if (cuiTaskbarStateController1.State == cuiTaskbarStateController.TaskbarStates.Default)
            {
                progressStateButton.Checked = true;
                errorStateButton.Checked = false;
                pausedStateButton.Checked = false;
                SetStateButton_Click(progressStateButton, EventArgs.Empty);
            }
        }

        private void SetStateButton_Click(object sender, EventArgs e)
        {
            cuiTaskbarStateController.TaskbarStates newState = cuiTaskbarStateController.TaskbarStates.Default;
            string s = ((cuiButtonGroup)sender).Content;
            switch (s[2])
            {
                case 'r':
                    newState = cuiTaskbarStateController.TaskbarStates.Error;
                    break;
                case 'o':
                    newState = cuiTaskbarStateController.TaskbarStates.Progress;
                    break;
                case 'u':
                    newState = cuiTaskbarStateController.TaskbarStates.Paused;
                    break;
            }

            cuiTaskbarStateController1.State = newState;
            cuiLabel3.Content = s;
        }

        private void cuiFileDropper1_FileDropped(object sender, FileDroppedEventArgs e)
        {
            Image img = Image.FromFile(e.FileName);
            using (Image imgClone = (Image)img.Clone())
            {
                cuiTaskbarBadgeController1.Image = imgClone;
                cuiPictureBox1.ImageTint = Color.White;
                cuiPictureBox1.Content = img;
            }
        }

        private void ClearBadgeImageButton_Click(object sender, EventArgs e)
        {
            if (cuiPictureBox1.Content != Resources.ic_fluent_image_24_regular)
            {
                cuiPictureBox1.Content?.Dispose();
                cuiPictureBox1.Content = Resources.ic_fluent_image_24_regular;
                cuiPictureBox1.ImageTint = Color.Gray;
            }

            cuiTaskbarBadgeController1.Image?.Dispose();
            cuiTaskbarBadgeController1.Image = null;
        }

        private void badgeNumericValueSlider_ValueChanged(object sender, EventArgs e)
        {
            cuiLabel9.Content = ((int)(badgeNumericValueSlider.Value * 0.1d)).ToString();
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            cuiTaskbarBadgeController1.NumericValue = int.Parse(cuiLabel9.Content);
        }

        private void ClearStateButton_Click(object sender, EventArgs e)
        {
            progressStateButton.Checked = false;
            errorStateButton.Checked = false;
            pausedStateButton.Checked = false;
            cuiTaskbarStateController1.State = cuiTaskbarStateController.TaskbarStates.Default;
            cuiLabel3.Content = "Default";
        }

        private void cuiButton4_Click(object sender, EventArgs e)
        {
            badgeNumericValueSlider.Value = 0;
            ClearBadgeImageButton_Click(sender, e);
        }
    }
}
