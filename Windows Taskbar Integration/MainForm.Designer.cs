namespace Windows_Taskbar_Integration
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cuiTaskbarBadgeController1 = new CuoreUI.Components.cuiTaskbarBadgeController();
            this.cuiTaskbarStateController1 = new CuoreUI.Components.cuiTaskbarStateController(this.components);
            this.stateValueSlider = new CuoreUI.Controls.cuiSlider();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.cuiButton3 = new CuoreUI.Controls.cuiButton();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            this.progressStateButton = new CuoreUI.Controls.cuiButtonGroup();
            this.errorStateButton = new CuoreUI.Controls.cuiButtonGroup();
            this.pausedStateButton = new CuoreUI.Controls.cuiButtonGroup();
            this.cuiPanel4 = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel11 = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiFileDropper1 = new CuoreUI.Controls.cuiFileDropper();
            this.cuiLabel8 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            this.cuiPanel3 = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel10 = new CuoreUI.Controls.cuiLabel();
            this.cuiButton4 = new CuoreUI.Controls.cuiButton();
            this.cuiLabel9 = new CuoreUI.Controls.cuiLabel();
            this.badgeNumericValueSlider = new CuoreUI.Controls.cuiSlider();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            this.cuiTooltipHover1 = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.cuiTooltipHover2 = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.cuiTooltipHover3 = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.cuiTooltipHover4 = new CuoreUI.Components.cuiTooltipHover(this.components);
            this.cuiLabel12 = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiLabel13 = new CuoreUI.Controls.cuiLabel();
            this.cuoreLogo = new CuoreUI.Controls.cuiPictureBox();
            this.cuiLabel14 = new CuoreUI.Controls.cuiLabel();
            this.cuiPanel1.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanel4.SuspendLayout();
            this.cuiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiTaskbarBadgeController1
            // 
            this.cuiTaskbarBadgeController1.Description = "";
            this.cuiTaskbarBadgeController1.Image = null;
            this.cuiTaskbarBadgeController1.NumericBackColor = System.Drawing.Color.Red;
            this.cuiTaskbarBadgeController1.NumericFont = new System.Drawing.Font("Microsoft YaHei UI", 8F, System.Drawing.FontStyle.Bold);
            this.cuiTaskbarBadgeController1.NumericForeColor = System.Drawing.Color.White;
            this.cuiTaskbarBadgeController1.NumericValue = 0;
            this.cuiTaskbarBadgeController1.TargetForm = this;
            // 
            // cuiTaskbarStateController1
            // 
            this.cuiTaskbarStateController1.MaxValue = 100;
            this.cuiTaskbarStateController1.ProgressValue = 50;
            this.cuiTaskbarStateController1.State = CuoreUI.Components.cuiTaskbarStateController.TaskbarStates.Default;
            this.cuiTaskbarStateController1.TargetForm = this;
            // 
            // stateValueSlider
            // 
            this.stateValueSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stateValueSlider.BackColor = System.Drawing.Color.White;
            this.stateValueSlider.Location = new System.Drawing.Point(11, 30);
            this.stateValueSlider.MaxValue = 100F;
            this.stateValueSlider.MinValue = 0F;
            this.stateValueSlider.Name = "stateValueSlider";
            this.stateValueSlider.Size = new System.Drawing.Size(280, 24);
            this.stateValueSlider.TabIndex = 0;
            this.stateValueSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.stateValueSlider.ThumbOutlineThickness = 3;
            this.stateValueSlider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.stateValueSlider.Value = 50F;
            this.stateValueSlider.ValueChanged += new System.EventHandler(this.stateValueSlider_ValueChanged);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.BackColor = System.Drawing.Color.White;
            this.cuiLabel1.Content = "Progress\\ Value";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(11, 11);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(99, 13);
            this.cuiLabel1.TabIndex = 1;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.BackColor = System.Drawing.Color.White;
            this.cuiLabel2.Content = "50%";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel2.ForeColor = System.Drawing.Color.Gray;
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(109, 11);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(130, 13);
            this.cuiLabel2.TabIndex = 2;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.Controls.Add(this.cuiLabel2);
            this.cuiPanel1.Controls.Add(this.stateValueSlider);
            this.cuiPanel1.Controls.Add(this.cuiLabel1);
            this.cuiPanel1.Location = new System.Drawing.Point(17, 67);
            this.cuiPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel1.Size = new System.Drawing.Size(302, 64);
            this.cuiPanel1.TabIndex = 3;
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Controls.Add(this.cuiButton3);
            this.cuiPanel2.Controls.Add(this.cuiLabel3);
            this.cuiPanel2.Controls.Add(this.cuiLabel4);
            this.cuiPanel2.Location = new System.Drawing.Point(17, 147);
            this.cuiPanel2.Margin = new System.Windows.Forms.Padding(8);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.Padding = new System.Windows.Forms.Padding(8);
            this.cuiPanel2.PanelColor = System.Drawing.Color.White;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel2.Size = new System.Drawing.Size(302, 118);
            this.cuiPanel2.TabIndex = 4;
            // 
            // cuiButton3
            // 
            this.cuiButton3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiButton3.BackColor = System.Drawing.Color.White;
            this.cuiButton3.CheckButton = false;
            this.cuiButton3.Checked = false;
            this.cuiButton3.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton3.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton3.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton3.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton3.Content = "Clear";
            this.cuiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton3.ForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverBackground = System.Drawing.Color.White;
            this.cuiButton3.HoveredImageTint = System.Drawing.Color.Black;
            this.cuiButton3.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton3.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton3.Image")));
            this.cuiButton3.ImageAutoCenter = true;
            this.cuiButton3.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton3.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.Location = new System.Drawing.Point(14, 62);
            this.cuiButton3.Name = "cuiButton3";
            this.cuiButton3.NormalBackground = System.Drawing.Color.White;
            this.cuiButton3.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton3.NormalImageTint = System.Drawing.Color.Black;
            this.cuiButton3.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.OutlineThickness = 1F;
            this.cuiButton3.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton3.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton3.PressedImageTint = System.Drawing.Color.Black;
            this.cuiButton3.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton3.Rounding = new System.Windows.Forms.Padding(22);
            this.cuiButton3.Size = new System.Drawing.Size(280, 45);
            this.cuiButton3.TabIndex = 5;
            this.cuiButton3.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton3.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton3.Click += new System.EventHandler(this.ClearStateButton_Click);
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.BackColor = System.Drawing.Color.White;
            this.cuiLabel3.Content = "Default";
            this.cuiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel3.ForeColor = System.Drawing.Color.Gray;
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel3.Location = new System.Drawing.Point(49, 11);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(130, 13);
            this.cuiLabel3.TabIndex = 2;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel4
            // 
            this.cuiLabel4.BackColor = System.Drawing.Color.White;
            this.cuiLabel4.Content = "State";
            this.cuiLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel4.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel4.Location = new System.Drawing.Point(11, 11);
            this.cuiLabel4.Name = "cuiLabel4";
            this.cuiLabel4.Size = new System.Drawing.Size(38, 13);
            this.cuiLabel4.TabIndex = 1;
            this.cuiLabel4.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // progressStateButton
            // 
            this.progressStateButton.BackColor = System.Drawing.Color.White;
            this.progressStateButton.Checked = false;
            this.progressStateButton.CheckedBackground = System.Drawing.Color.LimeGreen;
            this.progressStateButton.CheckedForeColor = System.Drawing.Color.White;
            this.progressStateButton.CheckedImageTint = System.Drawing.Color.White;
            this.progressStateButton.CheckedOutline = System.Drawing.Color.Empty;
            this.progressStateButton.Content = "Progress";
            this.progressStateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressStateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.progressStateButton.ForeColor = System.Drawing.Color.Black;
            this.progressStateButton.Group = 1;
            this.progressStateButton.HoverBackground = System.Drawing.Color.White;
            this.progressStateButton.HoveredImageTint = System.Drawing.Color.Black;
            this.progressStateButton.HoverForeColor = System.Drawing.Color.Black;
            this.progressStateButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressStateButton.Image = ((System.Drawing.Image)(resources.GetObject("progressStateButton.Image")));
            this.progressStateButton.ImageAutoCenter = true;
            this.progressStateButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.progressStateButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.progressStateButton.Location = new System.Drawing.Point(31, 176);
            this.progressStateButton.Name = "progressStateButton";
            this.progressStateButton.NormalBackground = System.Drawing.Color.White;
            this.progressStateButton.NormalForeColor = System.Drawing.Color.Black;
            this.progressStateButton.NormalImageTint = System.Drawing.Color.Black;
            this.progressStateButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressStateButton.OutlineThickness = 1F;
            this.progressStateButton.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.progressStateButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.progressStateButton.PressedImageTint = System.Drawing.Color.Black;
            this.progressStateButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.progressStateButton.Rounding = new System.Windows.Forms.Padding(12);
            this.progressStateButton.Size = new System.Drawing.Size(87, 24);
            this.progressStateButton.TabIndex = 6;
            this.progressStateButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.progressStateButton.TextOffset = new System.Drawing.Point(0, 0);
            this.progressStateButton.Click += new System.EventHandler(this.SetStateButton_Click);
            // 
            // errorStateButton
            // 
            this.errorStateButton.BackColor = System.Drawing.Color.White;
            this.errorStateButton.Checked = false;
            this.errorStateButton.CheckedBackground = System.Drawing.Color.Red;
            this.errorStateButton.CheckedForeColor = System.Drawing.Color.White;
            this.errorStateButton.CheckedImageTint = System.Drawing.Color.White;
            this.errorStateButton.CheckedOutline = System.Drawing.Color.Empty;
            this.errorStateButton.Content = "Error";
            this.errorStateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorStateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.errorStateButton.ForeColor = System.Drawing.Color.Black;
            this.errorStateButton.Group = 1;
            this.errorStateButton.HoverBackground = System.Drawing.Color.White;
            this.errorStateButton.HoveredImageTint = System.Drawing.Color.Black;
            this.errorStateButton.HoverForeColor = System.Drawing.Color.Black;
            this.errorStateButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.errorStateButton.Image = ((System.Drawing.Image)(resources.GetObject("errorStateButton.Image")));
            this.errorStateButton.ImageAutoCenter = true;
            this.errorStateButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.errorStateButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.errorStateButton.Location = new System.Drawing.Point(217, 176);
            this.errorStateButton.Name = "errorStateButton";
            this.errorStateButton.NormalBackground = System.Drawing.Color.White;
            this.errorStateButton.NormalForeColor = System.Drawing.Color.Black;
            this.errorStateButton.NormalImageTint = System.Drawing.Color.Black;
            this.errorStateButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.errorStateButton.OutlineThickness = 1F;
            this.errorStateButton.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.errorStateButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.errorStateButton.PressedImageTint = System.Drawing.Color.Black;
            this.errorStateButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.errorStateButton.Rounding = new System.Windows.Forms.Padding(12);
            this.errorStateButton.Size = new System.Drawing.Size(87, 24);
            this.errorStateButton.TabIndex = 8;
            this.errorStateButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.errorStateButton.TextOffset = new System.Drawing.Point(0, 0);
            this.errorStateButton.Click += new System.EventHandler(this.SetStateButton_Click);
            // 
            // pausedStateButton
            // 
            this.pausedStateButton.BackColor = System.Drawing.Color.White;
            this.pausedStateButton.Checked = false;
            this.pausedStateButton.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.pausedStateButton.CheckedForeColor = System.Drawing.Color.White;
            this.pausedStateButton.CheckedImageTint = System.Drawing.Color.White;
            this.pausedStateButton.CheckedOutline = System.Drawing.Color.Empty;
            this.pausedStateButton.Content = "Paused";
            this.pausedStateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pausedStateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pausedStateButton.ForeColor = System.Drawing.Color.Black;
            this.pausedStateButton.Group = 1;
            this.pausedStateButton.HoverBackground = System.Drawing.Color.White;
            this.pausedStateButton.HoveredImageTint = System.Drawing.Color.Black;
            this.pausedStateButton.HoverForeColor = System.Drawing.Color.Black;
            this.pausedStateButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pausedStateButton.Image = ((System.Drawing.Image)(resources.GetObject("pausedStateButton.Image")));
            this.pausedStateButton.ImageAutoCenter = true;
            this.pausedStateButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.pausedStateButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.pausedStateButton.Location = new System.Drawing.Point(124, 176);
            this.pausedStateButton.Name = "pausedStateButton";
            this.pausedStateButton.NormalBackground = System.Drawing.Color.White;
            this.pausedStateButton.NormalForeColor = System.Drawing.Color.Black;
            this.pausedStateButton.NormalImageTint = System.Drawing.Color.Black;
            this.pausedStateButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pausedStateButton.OutlineThickness = 1F;
            this.pausedStateButton.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.pausedStateButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.pausedStateButton.PressedImageTint = System.Drawing.Color.Black;
            this.pausedStateButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pausedStateButton.Rounding = new System.Windows.Forms.Padding(12);
            this.pausedStateButton.Size = new System.Drawing.Size(87, 24);
            this.pausedStateButton.TabIndex = 7;
            this.pausedStateButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.pausedStateButton.TextOffset = new System.Drawing.Point(0, 0);
            this.pausedStateButton.Click += new System.EventHandler(this.SetStateButton_Click);
            // 
            // cuiPanel4
            // 
            this.cuiPanel4.Controls.Add(this.cuiLabel11);
            this.cuiPanel4.Controls.Add(this.cuiPictureBox1);
            this.cuiPanel4.Controls.Add(this.cuiButton1);
            this.cuiPanel4.Controls.Add(this.cuiFileDropper1);
            this.cuiPanel4.Controls.Add(this.cuiLabel8);
            this.cuiPanel4.Location = new System.Drawing.Point(335, 67);
            this.cuiPanel4.Margin = new System.Windows.Forms.Padding(8);
            this.cuiPanel4.Name = "cuiPanel4";
            this.cuiPanel4.OutlineThickness = 1F;
            this.cuiPanel4.Padding = new System.Windows.Forms.Padding(8);
            this.cuiPanel4.PanelColor = System.Drawing.Color.White;
            this.cuiPanel4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPanel4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel4.Size = new System.Drawing.Size(302, 263);
            this.cuiPanel4.TabIndex = 9;
            // 
            // cuiLabel11
            // 
            this.cuiLabel11.BackColor = System.Drawing.Color.White;
            this.cuiLabel11.Content = "This\\ image\\ will\\ show\\ next\\ to\\ your\\ app\'s\\ taskbar\\ icon\\.\\ \\(Automatically\\" +
    " shrinks\\ to\\ 24px\\.\\)";
            this.cuiLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel11.ForeColor = System.Drawing.Color.Gray;
            this.cuiLabel11.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel11.Location = new System.Drawing.Point(11, 30);
            this.cuiLabel11.Name = "cuiLabel11";
            this.cuiLabel11.Size = new System.Drawing.Size(280, 28);
            this.cuiLabel11.TabIndex = 20;
            this.cuiLabel11.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackColor = System.Drawing.Color.White;
            this.cuiPictureBox1.Content = global::Windows_Taskbar_Integration.Properties.Resources.ic_fluent_image_24_regular;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.Gray;
            this.cuiPictureBox1.Location = new System.Drawing.Point(9, 5);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 0F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox1.Size = new System.Drawing.Size(22, 22);
            this.cuiPictureBox1.TabIndex = 18;
            // 
            // cuiButton1
            // 
            this.cuiButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiButton1.BackColor = System.Drawing.Color.White;
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton1.Content = "Clear";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverBackground = System.Drawing.Color.White;
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.Black;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton1.Image")));
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(11, 207);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.White;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.Black;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.OutlineThickness = 1F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.Black;
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(22);
            this.cuiButton1.Size = new System.Drawing.Size(280, 45);
            this.cuiButton1.TabIndex = 4;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Click += new System.EventHandler(this.ClearBadgeImageButton_Click);
            // 
            // cuiFileDropper1
            // 
            this.cuiFileDropper1.AllowDrop = true;
            this.cuiFileDropper1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiFileDropper1.BackColor = System.Drawing.Color.White;
            this.cuiFileDropper1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiFileDropper1.DashedOutline = true;
            this.cuiFileDropper1.DashedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiFileDropper1.DashLength = 8;
            this.cuiFileDropper1.Filter = "Images|*.gif;*.jpg;*.jpeg;*.bmp;*.wmf;*.png";
            this.cuiFileDropper1.ForeColor = System.Drawing.Color.Gray;
            this.cuiFileDropper1.HoverContent = "Release to drop";
            this.cuiFileDropper1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiFileDropper1.HoverUploadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiFileDropper1.Image = ((System.Drawing.Image)(resources.GetObject("cuiFileDropper1.Image")));
            this.cuiFileDropper1.ImagePadding = 2;
            this.cuiFileDropper1.ImageSize = new System.Drawing.Size(24, 24);
            this.cuiFileDropper1.ImageTint = System.Drawing.Color.Gray;
            this.cuiFileDropper1.Location = new System.Drawing.Point(11, 68);
            this.cuiFileDropper1.Multiselect = false;
            this.cuiFileDropper1.Name = "cuiFileDropper1";
            this.cuiFileDropper1.NormalContent = "Drop badge icon here";
            this.cuiFileDropper1.NormalForeColor = System.Drawing.Color.Gray;
            this.cuiFileDropper1.NormalUploadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiFileDropper1.OutlineThickness = 1F;
            this.cuiFileDropper1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiFileDropper1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiFileDropper1.Size = new System.Drawing.Size(280, 128);
            this.cuiFileDropper1.TabIndex = 3;
            this.cuiFileDropper1.Text = "cuiFileDropper1";
            this.cuiFileDropper1.UploadContent = "Click to choose";
            this.cuiFileDropper1.UploadWithClick = true;
            this.cuiFileDropper1.FileDropped += new System.EventHandler<CuoreUI.Controls.FileDroppedEventArgs>(this.cuiFileDropper1_FileDropped);
            // 
            // cuiLabel8
            // 
            this.cuiLabel8.BackColor = System.Drawing.Color.White;
            this.cuiLabel8.Content = "Badge\\ Image";
            this.cuiLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel8.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel8.Location = new System.Drawing.Point(31, 11);
            this.cuiLabel8.Name = "cuiLabel8";
            this.cuiLabel8.Size = new System.Drawing.Size(84, 13);
            this.cuiLabel8.TabIndex = 1;
            this.cuiLabel8.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel5
            // 
            this.cuiLabel5.Content = "State\\ Controller";
            this.cuiLabel5.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel5.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel5.Location = new System.Drawing.Point(17, 17);
            this.cuiLabel5.Margin = new System.Windows.Forms.Padding(8);
            this.cuiLabel5.Name = "cuiLabel5";
            this.cuiLabel5.Size = new System.Drawing.Size(210, 24);
            this.cuiLabel5.TabIndex = 10;
            this.cuiLabel5.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel6
            // 
            this.cuiLabel6.Content = "Badge\\ Controller";
            this.cuiLabel6.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel6.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel6.Location = new System.Drawing.Point(335, 17);
            this.cuiLabel6.Margin = new System.Windows.Forms.Padding(8);
            this.cuiLabel6.Name = "cuiLabel6";
            this.cuiLabel6.Size = new System.Drawing.Size(210, 24);
            this.cuiLabel6.TabIndex = 17;
            this.cuiLabel6.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPanel3
            // 
            this.cuiPanel3.Controls.Add(this.cuiLabel10);
            this.cuiPanel3.Controls.Add(this.cuiButton4);
            this.cuiPanel3.Controls.Add(this.cuiLabel9);
            this.cuiPanel3.Controls.Add(this.badgeNumericValueSlider);
            this.cuiPanel3.Controls.Add(this.cuiButton2);
            this.cuiPanel3.Controls.Add(this.cuiLabel7);
            this.cuiPanel3.Controls.Add(this.cuiPictureBox2);
            this.cuiPanel3.Location = new System.Drawing.Point(653, 67);
            this.cuiPanel3.Margin = new System.Windows.Forms.Padding(8);
            this.cuiPanel3.Name = "cuiPanel3";
            this.cuiPanel3.OutlineThickness = 1F;
            this.cuiPanel3.Padding = new System.Windows.Forms.Padding(8);
            this.cuiPanel3.PanelColor = System.Drawing.Color.White;
            this.cuiPanel3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPanel3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPanel3.Size = new System.Drawing.Size(302, 204);
            this.cuiPanel3.TabIndex = 10;
            // 
            // cuiLabel10
            // 
            this.cuiLabel10.BackColor = System.Drawing.Color.White;
            this.cuiLabel10.Content = "Creates\\ a\\ bitmap\\ of\\ a\\ badge\\ with\\ a\\ number\\ inside\\ it\\ dynamically\\.";
            this.cuiLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel10.ForeColor = System.Drawing.Color.Gray;
            this.cuiLabel10.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel10.Location = new System.Drawing.Point(11, 30);
            this.cuiLabel10.Name = "cuiLabel10";
            this.cuiLabel10.Size = new System.Drawing.Size(280, 28);
            this.cuiLabel10.TabIndex = 6;
            this.cuiLabel10.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiButton4
            // 
            this.cuiButton4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiButton4.BackColor = System.Drawing.Color.White;
            this.cuiButton4.CheckButton = false;
            this.cuiButton4.Checked = false;
            this.cuiButton4.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton4.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton4.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton4.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton4.Content = "Clear";
            this.cuiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton4.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton4.ForeColor = System.Drawing.Color.Black;
            this.cuiButton4.HoverBackground = System.Drawing.Color.White;
            this.cuiButton4.HoveredImageTint = System.Drawing.Color.Black;
            this.cuiButton4.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton4.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton4.Image")));
            this.cuiButton4.ImageAutoCenter = true;
            this.cuiButton4.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton4.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.Location = new System.Drawing.Point(11, 148);
            this.cuiButton4.Name = "cuiButton4";
            this.cuiButton4.NormalBackground = System.Drawing.Color.White;
            this.cuiButton4.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton4.NormalImageTint = System.Drawing.Color.Black;
            this.cuiButton4.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.OutlineThickness = 1F;
            this.cuiButton4.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton4.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton4.PressedImageTint = System.Drawing.Color.Black;
            this.cuiButton4.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton4.Rounding = new System.Windows.Forms.Padding(22);
            this.cuiButton4.Size = new System.Drawing.Size(280, 45);
            this.cuiButton4.TabIndex = 19;
            this.cuiButton4.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton4.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton4.Click += new System.EventHandler(this.cuiButton4_Click);
            // 
            // cuiLabel9
            // 
            this.cuiLabel9.BackColor = System.Drawing.Color.White;
            this.cuiLabel9.Content = "0";
            this.cuiLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel9.ForeColor = System.Drawing.Color.Gray;
            this.cuiLabel9.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel9.Location = new System.Drawing.Point(185, 11);
            this.cuiLabel9.Name = "cuiLabel9";
            this.cuiLabel9.Size = new System.Drawing.Size(106, 13);
            this.cuiLabel9.TabIndex = 3;
            this.cuiLabel9.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // badgeNumericValueSlider
            // 
            this.badgeNumericValueSlider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.badgeNumericValueSlider.BackColor = System.Drawing.Color.White;
            this.badgeNumericValueSlider.Location = new System.Drawing.Point(11, 63);
            this.badgeNumericValueSlider.MaxValue = 100F;
            this.badgeNumericValueSlider.MinValue = 0F;
            this.badgeNumericValueSlider.Name = "badgeNumericValueSlider";
            this.badgeNumericValueSlider.Size = new System.Drawing.Size(280, 24);
            this.badgeNumericValueSlider.TabIndex = 3;
            this.badgeNumericValueSlider.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.badgeNumericValueSlider.ThumbOutlineThickness = 3;
            this.badgeNumericValueSlider.TrackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.badgeNumericValueSlider.Value = 0F;
            this.badgeNumericValueSlider.ValueChanged += new System.EventHandler(this.badgeNumericValueSlider_ValueChanged);
            // 
            // cuiButton2
            // 
            this.cuiButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiButton2.BackColor = System.Drawing.Color.White;
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton2.Content = "Set";
            this.cuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton2.ForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverBackground = System.Drawing.Color.White;
            this.cuiButton2.HoveredImageTint = System.Drawing.Color.Black;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.Black;
            this.cuiButton2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton2.Image")));
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Location = new System.Drawing.Point(11, 93);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.Color.White;
            this.cuiButton2.NormalForeColor = System.Drawing.Color.Black;
            this.cuiButton2.NormalImageTint = System.Drawing.Color.Black;
            this.cuiButton2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.OutlineThickness = 1F;
            this.cuiButton2.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.cuiButton2.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cuiButton2.PressedImageTint = System.Drawing.Color.Black;
            this.cuiButton2.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(22);
            this.cuiButton2.Size = new System.Drawing.Size(280, 45);
            this.cuiButton2.TabIndex = 5;
            this.cuiButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Click += new System.EventHandler(this.cuiButton2_Click);
            // 
            // cuiLabel7
            // 
            this.cuiLabel7.BackColor = System.Drawing.Color.White;
            this.cuiLabel7.Content = "Dynamic\\ Numeric\\ Badge";
            this.cuiLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel7.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel7.Location = new System.Drawing.Point(33, 11);
            this.cuiLabel7.Name = "cuiLabel7";
            this.cuiLabel7.Size = new System.Drawing.Size(153, 13);
            this.cuiLabel7.TabIndex = 1;
            this.cuiLabel7.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.BackColor = System.Drawing.Color.White;
            this.cuiPictureBox2.Content = ((System.Drawing.Image)(resources.GetObject("cuiPictureBox2.Content")));
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.Gray;
            this.cuiPictureBox2.Location = new System.Drawing.Point(9, 3);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 0F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox2.Size = new System.Drawing.Size(26, 26);
            this.cuiPictureBox2.TabIndex = 21;
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(322, -12);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 0;
            this.cuiSeparator1.Size = new System.Drawing.Size(10, 541);
            this.cuiSeparator1.TabIndex = 18;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = true;
            // 
            // cuiTooltipHover1
            // 
            this.cuiTooltipHover1.BackColor = System.Drawing.Color.White;
            this.cuiTooltipHover1.Content = "(Image) cuiTaskbarBadgeController.Image";
            this.cuiTooltipHover1.ForeColor = System.Drawing.Color.Black;
            this.cuiTooltipHover1.TargetControl = this.cuiLabel8;
            this.cuiTooltipHover1.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.cuiTooltipHover1.TooltipPositionOffset = new System.Drawing.Size(0, 0);
            // 
            // cuiTooltipHover2
            // 
            this.cuiTooltipHover2.BackColor = System.Drawing.Color.White;
            this.cuiTooltipHover2.Content = "(int) cuiTaskbarBadgeController.NumericValue";
            this.cuiTooltipHover2.ForeColor = System.Drawing.Color.Black;
            this.cuiTooltipHover2.TargetControl = this.cuiLabel7;
            this.cuiTooltipHover2.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.cuiTooltipHover2.TooltipPositionOffset = new System.Drawing.Size(0, 0);
            // 
            // cuiTooltipHover3
            // 
            this.cuiTooltipHover3.BackColor = System.Drawing.Color.White;
            this.cuiTooltipHover3.Content = "(int) cuiTaskbarStateController.ProgressValue";
            this.cuiTooltipHover3.ForeColor = System.Drawing.Color.Black;
            this.cuiTooltipHover3.TargetControl = this.cuiLabel1;
            this.cuiTooltipHover3.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.cuiTooltipHover3.TooltipPositionOffset = new System.Drawing.Size(0, 0);
            // 
            // cuiTooltipHover4
            // 
            this.cuiTooltipHover4.BackColor = System.Drawing.Color.White;
            this.cuiTooltipHover4.Content = "(cuiTaskbarStateController.TaskbarStates) cuiTaskbarStateController.State";
            this.cuiTooltipHover4.ForeColor = System.Drawing.Color.Black;
            this.cuiTooltipHover4.TargetControl = this.cuiLabel4;
            this.cuiTooltipHover4.TooltipPosition = CuoreUI.Components.cuiTooltipHover.Position.Top;
            this.cuiTooltipHover4.TooltipPositionOffset = new System.Drawing.Size(0, 0);
            // 
            // cuiLabel12
            // 
            this.cuiLabel12.Content = "cuiTaskbarStateController";
            this.cuiLabel12.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel12.ForeColor = System.Drawing.Color.Gray;
            this.cuiLabel12.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel12.Location = new System.Drawing.Point(38, 43);
            this.cuiLabel12.Margin = new System.Windows.Forms.Padding(8);
            this.cuiLabel12.Name = "cuiLabel12";
            this.cuiLabel12.Size = new System.Drawing.Size(210, 15);
            this.cuiLabel12.TabIndex = 19;
            this.cuiLabel12.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPictureBox3.Content = ((System.Drawing.Image)(resources.GetObject("cuiPictureBox3.Content")));
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox3.Location = new System.Drawing.Point(21, 42);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 0F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox3.Size = new System.Drawing.Size(16, 16);
            this.cuiPictureBox3.TabIndex = 21;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.BackColor = System.Drawing.SystemColors.Control;
            this.cuiPictureBox4.Content = ((System.Drawing.Image)(resources.GetObject("cuiPictureBox4.Content")));
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox4.Location = new System.Drawing.Point(339, 42);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 0F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox4.Size = new System.Drawing.Size(16, 16);
            this.cuiPictureBox4.TabIndex = 23;
            // 
            // cuiLabel13
            // 
            this.cuiLabel13.Content = "cuiTaskbarBadgeController";
            this.cuiLabel13.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cuiLabel13.ForeColor = System.Drawing.Color.Gray;
            this.cuiLabel13.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel13.Location = new System.Drawing.Point(356, 43);
            this.cuiLabel13.Margin = new System.Windows.Forms.Padding(8);
            this.cuiLabel13.Name = "cuiLabel13";
            this.cuiLabel13.Size = new System.Drawing.Size(210, 15);
            this.cuiLabel13.TabIndex = 22;
            this.cuiLabel13.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuoreLogo
            // 
            this.cuoreLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuoreLogo.Content = ((System.Drawing.Image)(resources.GetObject("cuoreLogo.Content")));
            this.cuoreLogo.ImageTint = System.Drawing.Color.Gray;
            this.cuoreLogo.Location = new System.Drawing.Point(918, 466);
            this.cuoreLogo.Name = "cuoreLogo";
            this.cuoreLogo.OutlineThickness = 1F;
            this.cuoreLogo.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuoreLogo.Rotation = 0;
            this.cuoreLogo.Rounding = new System.Windows.Forms.Padding(0);
            this.cuoreLogo.Size = new System.Drawing.Size(42, 42);
            this.cuoreLogo.TabIndex = 24;
            // 
            // cuiLabel14
            // 
            this.cuiLabel14.Content = "All\\ samples\\ are\\ safe\\ to\\ play\\ around\\ with!";
            this.cuiLabel14.ForeColor = System.Drawing.Color.Gray;
            this.cuiLabel14.HorizontalAlignment = System.Drawing.StringAlignment.Far;
            this.cuiLabel14.Location = new System.Drawing.Point(700, 480);
            this.cuiLabel14.Name = "cuiLabel14";
            this.cuiLabel14.Size = new System.Drawing.Size(210, 17);
            this.cuiLabel14.TabIndex = 25;
            this.cuiLabel14.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 511);
            this.Controls.Add(this.cuiLabel14);
            this.Controls.Add(this.cuoreLogo);
            this.Controls.Add(this.cuiPictureBox4);
            this.Controls.Add(this.cuiLabel13);
            this.Controls.Add(this.cuiPictureBox3);
            this.Controls.Add(this.cuiLabel12);
            this.Controls.Add(this.cuiSeparator1);
            this.Controls.Add(this.cuiPanel3);
            this.Controls.Add(this.cuiLabel6);
            this.Controls.Add(this.cuiLabel5);
            this.Controls.Add(this.cuiPanel4);
            this.Controls.Add(this.errorStateButton);
            this.Controls.Add(this.pausedStateButton);
            this.Controls.Add(this.progressStateButton);
            this.Controls.Add(this.cuiPanel2);
            this.Controls.Add(this.cuiPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Taskbar (C# WinForms CuoreUI Sample)";
            this.cuiPanel1.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel4.ResumeLayout(false);
            this.cuiPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiTaskbarBadgeController cuiTaskbarBadgeController1;
        private CuoreUI.Components.cuiTaskbarStateController cuiTaskbarStateController1;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiSlider stateValueSlider;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiButtonGroup errorStateButton;
        private CuoreUI.Controls.cuiButtonGroup pausedStateButton;
        private CuoreUI.Controls.cuiButtonGroup progressStateButton;
        private CuoreUI.Controls.cuiPanel cuiPanel4;
        private CuoreUI.Controls.cuiFileDropper cuiFileDropper1;
        private CuoreUI.Controls.cuiLabel cuiLabel8;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiPanel cuiPanel3;
        private CuoreUI.Controls.cuiLabel cuiLabel9;
        private CuoreUI.Controls.cuiSlider badgeNumericValueSlider;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private CuoreUI.Controls.cuiButton cuiButton3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiButton cuiButton4;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Controls.cuiLabel cuiLabel10;
        private CuoreUI.Controls.cuiLabel cuiLabel11;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Components.cuiTooltipHover cuiTooltipHover1;
        private CuoreUI.Components.cuiTooltipHover cuiTooltipHover2;
        private CuoreUI.Components.cuiTooltipHover cuiTooltipHover3;
        private CuoreUI.Components.cuiTooltipHover cuiTooltipHover4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiLabel cuiLabel12;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiLabel cuiLabel13;
        private CuoreUI.Controls.cuiPictureBox cuoreLogo;
        private CuoreUI.Controls.cuiLabel cuiLabel14;
    }
}

