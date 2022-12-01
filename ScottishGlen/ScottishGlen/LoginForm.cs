using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net; //Include this namespace
using System.Management;
using BCrypt.Net;


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
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF"; // details to connect to the mssql db
            cnn = new SqlConnection(connetionString); // initialise connection with the login details
            cnn.Open(); // open connection

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = ""; // initialise the sql and output strings

            sql = "SELECT * FROM logins WHERE username = '" + usernameTextBox.Text + "';"; // sql statement to get the username
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            if (usernameTextBox.Text == "" || passwordTextBox.Text == "") // checks if the text boxes ar empty
            {
                incorrectDetailsLabel.Text = "Please fill in all fields!"; // displays error message
                incorrectDetailsLabel.Visible = true;
            }
            else if (dataReader.HasRows) // checks the username is in the database
            {
                while (dataReader.Read()) // loops through the records of the database
                {
                    if (BCrypt.Net.BCrypt.Verify(passwordTextBox.Text, dataReader.GetString(2))) // checks if the password is correct
                    {
                        DialogResult = DialogResult.OK; // loads the main form
                    }
                }
            }
            else
            {
                incorrectDetailsLabel.Text = "Username or password is incorrect!"; // displays error message if details are incorrect
                incorrectDetailsLabel.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //exits the program
        }
    }
}
