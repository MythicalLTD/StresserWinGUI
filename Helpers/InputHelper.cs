using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StresserWinGUI.Helpers
{
    public partial class InputHelper : Form
    {
        public static string input;
        public InputHelper(string message, string title)
        {
            InitializeComponent();
            label1.Text = message;
            this.Text = title;
            InputHelper.input = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendInput(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                sendInput(textBox1.Text);
            }
        }

        private void sendInput(string input)
        {
            if (input == null)
            {
                MessageBox.Show("Please fill in the input box","Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (input == "")
            {
                MessageBox.Show("Please fill in the input box", "Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            InputHelper.input = textBox1.Text;
            this.Close();
        }
    }
}
