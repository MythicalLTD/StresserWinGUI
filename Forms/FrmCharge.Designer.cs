namespace StresserWinGUI.Forms
{
    partial class FrmCharge
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCharge));
            progressBar1 = new ProgressBar();
            navbar = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            pbAppIcon = new PictureBox();
            label5 = new Label();
            label7 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblclose = new Label();
            lblminimize = new Label();
            lblappname = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            navbar.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 98);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(887, 21);
            progressBar1.TabIndex = 0;
            // 
            // navbar
            // 
            navbar.BackColor = Color.FromArgb(15, 18, 22);
            navbar.Controls.Add(panel1);
            navbar.Controls.Add(lblclose);
            navbar.Controls.Add(lblminimize);
            navbar.Controls.Add(lblappname);
            navbar.Dock = DockStyle.Top;
            navbar.Location = new Point(0, 0);
            navbar.Name = "navbar";
            navbar.Size = new Size(914, 31);
            navbar.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 18, 22);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 31);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(15, 18, 22);
            panel2.Controls.Add(pbAppIcon);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(914, 31);
            panel2.TabIndex = 3;
            // 
            // pbAppIcon
            // 
            pbAppIcon.Image = (Image)resources.GetObject("pbAppIcon.Image");
            pbAppIcon.Location = new Point(9, 4);
            pbAppIcon.Name = "pbAppIcon";
            pbAppIcon.Size = new Size(20, 20);
            pbAppIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            pbAppIcon.TabIndex = 3;
            pbAppIcon.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(240, 238, 238);
            label5.Location = new Point(884, 5);
            label5.Name = "label5";
            label5.Size = new Size(18, 19);
            label5.TabIndex = 2;
            label5.Text = "X";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 8);
            label7.Name = "label7";
            label7.Size = new Size(111, 14);
            label7.TabIndex = 0;
            label7.Text = "StresserWinGui";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(240, 238, 238);
            label2.Location = new Point(231, 6);
            label2.Name = "label2";
            label2.Size = new Size(18, 19);
            label2.TabIndex = 2;
            label2.Text = "X";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(240, 238, 238);
            label3.Location = new Point(201, 4);
            label3.Name = "label3";
            label3.Size = new Size(21, 19);
            label3.TabIndex = 1;
            label3.Text = "--";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 8);
            label4.Name = "label4";
            label4.Size = new Size(111, 14);
            label4.TabIndex = 0;
            label4.Text = "StresserWinGui";
            // 
            // lblclose
            // 
            lblclose.AutoSize = true;
            lblclose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblclose.ForeColor = Color.FromArgb(240, 238, 238);
            lblclose.Location = new Point(883, 6);
            lblclose.Name = "lblclose";
            lblclose.Size = new Size(18, 19);
            lblclose.TabIndex = 2;
            lblclose.Text = "X";
            // 
            // lblminimize
            // 
            lblminimize.AutoSize = true;
            lblminimize.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblminimize.ForeColor = Color.FromArgb(240, 238, 238);
            lblminimize.Location = new Point(853, 4);
            lblminimize.Name = "lblminimize";
            lblminimize.Size = new Size(21, 19);
            lblminimize.TabIndex = 1;
            lblminimize.Text = "--";
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
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold);
            label1.Location = new Point(201, 46);
            label1.Name = "label1";
            label1.Size = new Size(591, 18);
            label1.TabIndex = 1;
            label1.Text = "BotNET recharge required! Please wait for the botnet to be ready!";
            // 
            // FrmCharge
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 23, 28);
            ClientSize = new Size(914, 133);
            Controls.Add(navbar);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Font = new Font("Verdana", 9F, FontStyle.Bold);
            ForeColor = Color.FromArgb(240, 238, 238);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCharge";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmCharge";
            Load += FrmCharge_Load;
            navbar.ResumeLayout(false);
            navbar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbAppIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Panel navbar;
        private Label lblclose;
        private Label lblminimize;
        private Label lblappname;
        private Panel panel1;
        private Panel panel2;
        private Label label5;
        private Label label7;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pbAppIcon;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}