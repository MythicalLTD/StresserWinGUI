using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StresserWinGUI.Forms
{
    public partial class FrmCharge : Form
    {
        public FrmCharge()
        {
            InitializeComponent();
            timer1.Interval = 1000;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 120;
            progressBar1.Value = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            int increment = rand.Next(1, 5); // Random increment between 1 and 4

            progressBar1.Value += increment;

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void FrmCharge_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
