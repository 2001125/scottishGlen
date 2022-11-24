using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottishGlen
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            // The password character is an asterisk.
            passwordTextBox.PasswordChar = '*';

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        private void showPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = showPasswordCheck.Checked ? '\0' : '*';
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "password";

            if (usernameTextBox.Text == username && passwordTextBox.Text == password)
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
