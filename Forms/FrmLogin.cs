using StresserWinGUI.Helpers;
using System;
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
    public partial class FrmLogin : Form
    {
        public static string username;
        public static int debug_value = 49112149;
        public FrmLogin()
        {
            InitializeComponent();
            UIStyler.ApplyStyles(this, true);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Program.Stop();
        }

        private void lblminimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin(txtUsername.Text, txtPassword.Text);
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformLogin(txtUsername.Text, txtPassword.Text);
            }
        }

        /**
         * Perform a login action
         * 
         * @param string username Username
         * @param string password Password
         * 
         * @return void
         */
        private void PerformLogin(string username, string password)
        {
            FrmAlert x = new FrmAlert();
            if (username != "")
            {
                if (password != "")
                {
                    if (AccountManager.Verify(username, password) == true)
                    {
                        x.showAlert($"Logged in as {username}", FrmAlert.enmType.Succes);
                        FrmLogin.username = username;
                        FrmMain xmain = new FrmMain();
                        xmain.Show();
                        this.Hide();
                    }
                    else
                    {
                        x.showAlert("Login Failed!",FrmAlert.enmType.Error);
                    }
                }
                else
                {
                    x.showAlert("Please specify a password", FrmAlert.enmType.Warning);
                }
            }
            else
            {
                x.showAlert("Please specify an username!", FrmAlert.enmType.Warning);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                PerformLogin(txtUsername.Text, txtPassword.Text);
            }
        }
    }
}
