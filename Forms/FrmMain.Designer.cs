namespace StresserWinGUI.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            navbar = new Panel();
            pbAppIcon = new PictureBox();
            lblclose = new Label();
            lblminimize = new Label();
            lblappname = new Label();
            DragControl = new Guna.UI2.WinForms.Guna2DragControl(components);
            lstBots = new ListBox();
            btnAddNewBot = new Guna.UI2.WinForms.Guna2Button();
            deletebote = new Guna.UI2.WinForms.Guna2Button();
            btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).BeginInit();
            SuspendLayout();
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(15, 18, 22);
            navbar.Controls.Add(pbAppIcon);
            navbar.Controls.Add(lblclose);
            navbar.Controls.Add(lblminimize);
            navbar.Controls.Add(lblappname);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(766, 29);
            navbar.TabIndex = 2;
            navbar.Paint += navbar_Paint;
            // 
            // pbAppIcon
            // 
            pbAppIcon.Image = (Image)resources.GetObject("pbAppIcon.Image");
            pbAppIcon.Location = new Point(11, 4);
            pbAppIcon.Name = "pbAppIcon";
            pbAppIcon.Size = new Size(23, 19);
            pbAppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAppIcon.TabIndex = 3;
            pbAppIcon.TabStop = false;
            // 
            // lblclose
            // 
            lblclose.AutoSize = true;
            lblclose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblclose.ForeColor = Color.FromArgb(240, 238, 238);
            lblclose.Location = new Point(736, 4);
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
            lblminimize.Location = new Point(713, 2);
            lblminimize.Name = "lblminimize";
            lblminimize.Size = new Size(21, 19);
            lblminimize.TabIndex = 1;
            lblminimize.Text = "--";
            lblminimize.Click += lblminimize_Click;
            // 
            // lblappname
            // 
            lblappname.AutoSize = true;
            lblappname.Location = new Point(38, 6);
            lblappname.Name = "lblappname";
            lblappname.Size = new Size(111, 14);
            lblappname.TabIndex = 0;
            lblappname.Text = "StresserWinGui";
            // 
            // DragControl
            // 
            DragControl.DockIndicatorTransparencyValue = 0.5D;
            DragControl.TargetControl = navbar;
            DragControl.UseTransparentDrag = true;
            // 
            // lstBots
            // 
            lstBots.FormattingEnabled = true;
            lstBots.ItemHeight = 14;
            lstBots.Location = new Point(11, 35);
            lstBots.Name = "lstBots";
            lstBots.Size = new Size(582, 172);
            lstBots.TabIndex = 4;
            // 
            // btnAddNewBot
            // 
            btnAddNewBot.BorderRadius = 12;
            btnAddNewBot.BorderThickness = 2;
            btnAddNewBot.CustomBorderColor = Color.Transparent;
            btnAddNewBot.CustomizableEdges = customizableEdges1;
            btnAddNewBot.DisabledState.BorderColor = Color.DarkGray;
            btnAddNewBot.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddNewBot.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddNewBot.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddNewBot.FillColor = Color.FromArgb(211, 206, 0);
            btnAddNewBot.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNewBot.ForeColor = Color.Black;
            btnAddNewBot.Location = new Point(599, 35);
            btnAddNewBot.Name = "btnAddNewBot";
            btnAddNewBot.PressedColor = Color.Transparent;
            btnAddNewBot.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddNewBot.Size = new Size(160, 37);
            btnAddNewBot.TabIndex = 5;
            btnAddNewBot.Text = "Add a new bot";
            btnAddNewBot.Click += btnAddNewBot_Click;
            // 
            // deletebote
            // 
            deletebote.BorderRadius = 12;
            deletebote.BorderThickness = 2;
            deletebote.CustomBorderColor = Color.Transparent;
            deletebote.CustomizableEdges = customizableEdges3;
            deletebote.DisabledState.BorderColor = Color.DarkGray;
            deletebote.DisabledState.CustomBorderColor = Color.DarkGray;
            deletebote.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            deletebote.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            deletebote.FillColor = Color.FromArgb(211, 206, 0);
            deletebote.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deletebote.ForeColor = Color.Black;
            deletebote.Location = new Point(599, 78);
            deletebote.Name = "deletebote";
            deletebote.PressedColor = Color.Transparent;
            deletebote.ShadowDecoration.CustomizableEdges = customizableEdges4;
            deletebote.Size = new Size(160, 37);
            deletebote.TabIndex = 6;
            deletebote.Text = "Delete a bot";
            deletebote.Click += guna2Button1_Click;
            // 
            // btnrefresh
            // 
            btnrefresh.BorderRadius = 12;
            btnrefresh.BorderThickness = 2;
            btnrefresh.CustomBorderColor = Color.Transparent;
            btnrefresh.CustomizableEdges = customizableEdges5;
            btnrefresh.DisabledState.BorderColor = Color.DarkGray;
            btnrefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnrefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnrefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnrefresh.FillColor = Color.FromArgb(211, 206, 0);
            btnrefresh.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnrefresh.ForeColor = Color.Black;
            btnrefresh.Location = new Point(599, 121);
            btnrefresh.Name = "btnrefresh";
            btnrefresh.PressedColor = Color.Transparent;
            btnrefresh.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnrefresh.Size = new Size(160, 37);
            btnrefresh.TabIndex = 7;
            btnrefresh.Text = "Refresh";
            btnrefresh.Click += btnrefresh_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 12;
            guna2Button1.BorderThickness = 2;
            guna2Button1.CustomBorderColor = Color.Transparent;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(211, 206, 0);
            guna2Button1.Font = new Font("Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(599, 164);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = Color.Transparent;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(160, 37);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Nuke";
            guna2Button1.Click += guna2Button1_Click_1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 23, 28);
            ClientSize = new Size(766, 221);
            Controls.Add(guna2Button1);
            Controls.Add(btnrefresh);
            Controls.Add(deletebote);
            Controls.Add(btnAddNewBot);
            Controls.Add(lstBots);
            Controls.Add(navbar);
            Font = new Font("Verdana", 9F, FontStyle.Bold);
            ForeColor = Color.FromArgb(240, 238, 238);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stresser";
            Load += FrmMain_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel navbar;
        private Label lblclose;
        private Label lblminimize;
        private Label lblappname;
        private PictureBox pbAppIcon;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private ListBox lstAttacks;
        private ListBox lstBots;
        private Guna.UI2.WinForms.Guna2Button btnAddNewBot;
        private Guna.UI2.WinForms.Guna2Button deletebote;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}