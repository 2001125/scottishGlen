using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net; //Include this namespace
using System.Management;
using System.Text.RegularExpressions;

namespace ScottishGlen
{
    public partial class softwareEditForm : Form
    {
        public softwareEditForm()
        {
            InitializeComponent();
            dbConnect();
        }

        void dbConnect() // function to connection to the database and display all records
        {
            displaySoftware.Items.Clear(); // clears the list so new data is shown without old data repeating itself

            string connetionString; // initialise connectionString to be valued with the details further down
            SqlConnection cnn; // establish sql connection
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF"; // connection details to mssql database server
            cnn = new SqlConnection(connetionString);
            cnn.Open(); // open the db connection

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = ""; // initialise the sql and output strings

            sql = "SELECT * FROM software"; // sql statement to get all the records from the assets database
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read()) // while loop to loop through records in the database
            {
                // add each field from current record to output string
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + "\n";
                displaySoftware.Items.Add(Output); // add current Output to the list box to display
                Output = ""; // clear Output so old Output isn't displayed again
            } // while loop

            cnn.Close(); // close connection
        } // dbConnect()

        private void editButton_Click(object sender, EventArgs e)
        {
            
        }

        private void displaySoftware_SelectedIndexChanged(object sender, EventArgs e)
        {
            string current = displaySoftware.SelectedItem.ToString(); // turns the current selected item into a string
            string trim = Regex.Replace(current, @" - ", "-"); //  removes spaces between - 
            string[] currentID = trim.Split('-'); // splits the string up to individual items in an array with [0] being the ID

            clearBoxes();

            // assigns all text boxes to the current selected item in the listbox
            osBox.Text = currentID[1];
            versionBox.Text = currentID[2];
            manufacturerBox.Text = currentID[3];
        }

        private void clearBoxes()
        {
            osBox.Clear();
            versionBox.Clear();
            manufacturerBox.Clear();
        }

        private void editButton_Click_1(object sender, EventArgs e)
        {
            if (displaySoftware.SelectedIndex >= 0)
            {
                string current = displaySoftware.SelectedItem.ToString(); // turns the current selected item into a string
                string[] currentID = current.Split('-'); // splits the string up to individual items in an array with [0] being the ID

                string connetionString; // initialise connectionString to be valued with the details further down
                SqlConnection cnn; // establish sql connection
                connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF"; // connection details to mssql database server
                cnn = new SqlConnection(connetionString);
                cnn.Open(); // open the db connection

                SqlCommand command;
                SqlDataReader dataReader;
                String sql; // initialise the sql string

                sql = "UPDATE software SET os = '" + osBox.Text + "', osVersion = '" + versionBox.Text + "', manufacturer = '" + manufacturerBox.Text + "' WHERE id = " + currentID[0]; // sql statement to get all the records from the assets database
                //sql = "UPDATE assets SET systName = '" + sysNameBox.Text + "', model = '" + modelBox.Text + "' WHERE id = " + currentID[0] + ";";
                command = new SqlCommand(sql, cnn);
                dataReader = command.ExecuteReader();
            }
            else
            {
                MessageBox.Show("Please select a record to edit!");
            }

            dbConnect(); // refreshes the listbox
            clearBoxes();
        }
    }
}
