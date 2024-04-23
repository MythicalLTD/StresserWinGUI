namespace StresserWinGUI.Forms
{
    partial class FrmLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            lblappname = new Label();
            navbar = new Panel();
            lblclose = new Label();
            lblminimize = new Label();
            pbAppIcon = new PictureBox();
            DragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).BeginInit();
            SuspendLayout();
            // 
            // lblappname
            // 
            lblappname.AutoSize = true;
            lblappname.Location = new Point(35, 8);
            lblappname.Name = "lblappname";
            lblappname.Size = new Size(111, 14);
            lblappname.TabIndex = 0;
            lblappname.Text = "StresserWinGui";
            // 
            // navbar
            // 
            navbar.Controls.Add(lblclose);
            navbar.Controls.Add(lblminimize);
            navbar.Controls.Add(lblappname);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(914, 31);
            navbar.TabIndex = 1;
            // 
            // lblclose
            // 
            lblclose.AutoSize = true;
            lblclose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblclose.ForeColor = Color.FromArgb(240, 238, 238);
            lblclose.Location = new Point(887, 6);
            lblclose.Name = "lblclose";
            lblclose.Size = new Size(18, 19);
            lblclose.TabIndex = 2;
            lblclose.Text = "X";
            lblclose.Click += lblclose_Click;
            // 
            // lblminimize
            // 
            lblminimize.AutoSize = true;
            lblminimize.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblminimize.ForeColor = Color.FromArgb(240, 238, 238);
            lblminimize.Location = new Point(857, 4);
            lblminimize.Name = "lblminimize";
            lblminimize.Size = new Size(21, 19);
            lblminimize.TabIndex = 1;
            lblminimize.Text = "--";
            lblminimize.Click += lblminimize_Click;
            // 
            // pbAppIcon
            // 
            pbAppIcon.Image = (Image)resources.GetObject("pbAppIcon.Image");
            pbAppIcon.Location = new Point(9, 5);
            pbAppIcon.Name = "pbAppIcon";
            pbAppIcon.Size = new Size(20, 20);
            pbAppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAppIcon.TabIndex = 2;
            pbAppIcon.TabStop = false;
            // 
            // DragControl
            // 
            DragControl.DockIndicatorTransparencyValue = 0.5D;
            DragControl.TargetControl = navbar;
            DragControl.UseTransparentDrag = true;
            // 
            // Elipse
            // 
            Elipse.BorderRadius = 24;
            Elipse.TargetControl = this;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 23, 28);
            ClientSize = new Size(914, 420);
            Controls.Add(pbAppIcon);
            Controls.Add(navbar);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(240, 238, 238);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            Load += FrmLogin_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblappname;
        private Panel navbar;
        private Label lblclose;
        private Label lblminimize;
        private PictureBox pbAppIcon;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
    }
}