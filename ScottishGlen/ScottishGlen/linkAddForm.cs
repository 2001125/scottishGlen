﻿using System;
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

namespace ScottishGlen
{
    public partial class linkAddForm : Form
    {
        public linkAddForm()
        {
            InitializeComponent();
            dbConnectHardware();
            dbConnectSoftware();
        }

        private void linkAddForm_Load(object sender, EventArgs e)
        {

        }

        void dbConnectHardware() // function to connection to the database and display all records
        {
            displayHardware.Items.Clear(); // clears the list so new data is shown without old data repeating itself
            displaySoftware.Items.Clear(); // clears the list so new data is shown without old data repeating itself

            string connetionString; // initialise connectionString to be valued with the details further down
            SqlConnection cnn; // establish sql connection
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF"; // connection details to mssql database server
            cnn = new SqlConnection(connetionString);
            cnn.Open(); // open the db connection

            // get the hardware data
            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = ""; // initialise the sql and output strings

            sql = "SELECT * FROM assets"; // sql statement to get all the records from the assets database
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read()) // while loop to loop through records in the database
            {
                // add each field from current record to output string
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + " - " + dataReader.GetValue(5) + " - " + dataReader.GetValue(6) + " - " + dataReader.GetValue(7) + "\n";
                displayHardware.Items.Add(Output); // add current Output to the list box to display
                Output = ""; // clear Output so old Output isn't displayed again
            } // while loop

            cnn.Close(); // close connection
        } // dbConnect()

        void dbConnectSoftware() // function to connection to the database and display all records
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

        private string getName(string table, string index)
        {
            string connetionString; // initialise connectionString to be valued with the details further down
            SqlConnection cnn; // establish sql connection
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF"; // connection details to mssql database server
            cnn = new SqlConnection(connetionString);
            cnn.Open(); // open the db connection

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = ""; // initialise the sql and output strings

            sql = "SELECT * FROM " + table + " WHERE id = " + index + ";"; // sql statement to get all the records from the assets database
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read()) // while loop to loop through records in the database
            {
                // add each field from current record to output string
                Output = dataReader.GetValue(1).ToString();
            } // while loop
            return Output;
        }

        private void addLinkButton_Click(object sender, EventArgs e)
        {
            string currentHardware = displayHardware.SelectedItem.ToString(); // turns the current selected item into a string
            string[] currentHardwareID = currentHardware.Split('-'); // splits the string up to individual items in an array with [0] being the ID
                                                                     
            string currentSoftware = displaySoftware.SelectedItem.ToString(); // turns the current selected item into a string
            string[] currentSoftwareID = currentSoftware.Split('-'); // splits the string up to individual items in an array with [0] being the ID

            string hardwareID = currentHardwareID[0].ToString();
            string softwareID = currentSoftwareID[0].ToString();
            
            if (displaySoftware.SelectedIndex >= 0 && displayHardware.SelectedIndex >= 0)
            {
                string hardwareName = getName("assets", hardwareID);
                string softwareName = getName("software", softwareID);


                string connetionString;
                SqlConnection cnn;
                connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF"; // details to connect to the mssql db
                cnn = new SqlConnection(connetionString); // initialise connection with the login details
                cnn.Open(); // open connection 

                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";

                // inserting all the values from the text box to the database in an sql statement
                sql = "INSERT INTO link VALUES('" + hardwareName + "', '" + softwareName + "'); ";
                command = new SqlCommand(sql, cnn); // initialise the sql command

                adapter.InsertCommand = new SqlCommand(sql, cnn); // start command
                adapter.InsertCommand.ExecuteNonQuery(); // execute command

                command.Dispose(); // dispose of the sql command
                cnn.Close(); // close connection

                MessageBox.Show("Link between " + hardwareName + " and " + softwareName + " has been made.");

            }
            else
            {
                MessageBox.Show("Please ensure an entry from both lists are selected.");
            }
        }
    }
}