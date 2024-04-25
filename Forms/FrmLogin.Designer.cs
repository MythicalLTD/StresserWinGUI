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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblappname = new Label();
            navbar = new Panel();
            lblclose = new Label();
            lblminimize = new Label();
            pbAppIcon = new PictureBox();
            DragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            Elipse = new Guna.UI2.WinForms.Guna2Elipse(components);
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            lblpwd = new Label();
            lblusername = new Label();
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
            navbar.BackColor = Color.FromArgb(15, 18, 22);
            navbar.Controls.Add(lblclose);
            navbar.Controls.Add(lblminimize);
            navbar.Controls.Add(lblappname);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(258, 31);
            navbar.TabIndex = 1;
            // 
            // lblclose
            // 
            lblclose.AutoSize = true;
            lblclose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblclose.ForeColor = Color.FromArgb(240, 238, 238);
            lblclose.Location = new Point(231, 6);
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
            lblminimize.Location = new Point(201, 4);
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
            // btnLogin
            // 
            btnLogin.BorderRadius = 12;
            btnLogin.BorderThickness = 2;
            btnLogin.CustomBorderColor = Color.Transparent;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(211, 206, 0);
            btnLogin.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(52, 162);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedColor = Color.Transparent;
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(160, 37);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Sign In";
            btnLogin.Click += btnLogin_Click;
            // 
            // txtUsername
            // 
            txtUsername.AcceptsTab = true;
            txtUsername.BorderColor = Color.FromArgb(16, 16, 16);
            txtUsername.BorderRadius = 6;
            txtUsername.BorderThickness = 2;
            txtUsername.CustomizableEdges = customizableEdges3;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = Color.FromArgb(26, 32, 38);
            txtUsername.FocusedState.BorderColor = Color.Transparent;
            txtUsername.FocusedState.FillColor = Color.Transparent;
            txtUsername.FocusedState.ForeColor = Color.Transparent;
            txtUsername.FocusedState.PlaceholderForeColor = Color.Transparent;
            txtUsername.Font = new Font("Nirmala UI", 8.9F, FontStyle.Bold);
            txtUsername.HoverState.BorderColor = Color.Transparent;
            txtUsername.HoverState.FillColor = Color.Transparent;
            txtUsername.HoverState.ForeColor = Color.Transparent;
            txtUsername.HoverState.PlaceholderForeColor = Color.Transparent;
            txtUsername.Location = new Point(18, 59);
            txtUsername.Margin = new Padding(2);
            txtUsername.MaxLength = 32;
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "NaysKutzu";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUsername.Size = new Size(229, 36);
            txtUsername.TabIndex = 1;
            txtUsername.KeyPress += txtUsername_KeyPress;
            // 
            // txtPassword
            // 
            txtPassword.AcceptsTab = true;
            txtPassword.BorderColor = Color.FromArgb(16, 16, 16);
            txtPassword.BorderRadius = 6;
            txtPassword.BorderThickness = 2;
            txtPassword.CustomizableEdges = customizableEdges1;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(26, 32, 38);
            txtPassword.FocusedState.BorderColor = Color.Transparent;
            txtPassword.FocusedState.FillColor = Color.Transparent;
            txtPassword.FocusedState.ForeColor = Color.Transparent;
            txtPassword.FocusedState.PlaceholderForeColor = Color.Transparent;
            txtPassword.Font = new Font("Nirmala UI", 8.9F, FontStyle.Bold);
            txtPassword.HoverState.BorderColor = Color.Transparent;
            txtPassword.HoverState.FillColor = Color.Transparent;
            txtPassword.HoverState.ForeColor = Color.Transparent;
            txtPassword.HoverState.PlaceholderForeColor = Color.Transparent;
            txtPassword.Location = new Point(18, 113);
            txtPassword.Margin = new Padding(2);
            txtPassword.MaxLength = 32;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "●●●●●●●●●●";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtPassword.Size = new Size(229, 36);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // lblpwd
            // 
            lblpwd.AutoSize = true;
            lblpwd.Font = new Font("Verdana", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblpwd.Location = new Point(22, 98);
            lblpwd.Name = "lblpwd";
            lblpwd.Size = new Size(73, 13);
            lblpwd.TabIndex = 5;
            lblpwd.Text = "Password:";
            // 
            // lblusername
            // 
            lblusername.AutoSize = true;
            lblusername.Font = new Font("Verdana", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusername.Location = new Point(26, 44);
            lblusername.Name = "lblusername";
            lblusername.Size = new Size(77, 13);
            lblusername.TabIndex = 6;
            lblusername.Text = "Username:";
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 23, 28);
            ClientSize = new Size(258, 216);
            Controls.Add(lblusername);
            Controls.Add(lblpwd);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(btnLogin);
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
            PerformLayout();
        }

        #endregion

        private Label lblappname;
        private Panel navbar;
        private Label lblclose;
        private Label lblminimize;
        private PictureBox pbAppIcon;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Label lblusername;
        private Label lblpwd;
    }
}