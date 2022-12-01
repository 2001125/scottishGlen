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

namespace ScottishGlen
{
    public partial class hardwareEditForm : Form
    {
        public hardwareEditForm()
        {
            InitializeComponent();
            dbConnect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void dbConnect() // function to connection to the database and display all records
        {
            displayAssets.Items.Clear(); // clears the list so new data is shown without old data repeating itself

            string connetionString; // initialise connectionString to be valued with the details further down
            SqlConnection cnn; // establish sql connection
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF"; // connection details to mssql database server
            cnn = new SqlConnection(connetionString);
            cnn.Open(); // open the db connection

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
                displayAssets.Items.Add(Output); // add current Output to the list box to display
                Output = ""; // clear Output so old Output isn't displayed again
            } // while loop

            cnn.Close(); // close connection
        } // dbConnect()

        private void editButton_Click(object sender, EventArgs e)
        {
            // in here make a variable that updates the selected record to what is in the text boxes, either through checking what is different
            // or just updating every field

            dbConnect(); // refreshes the listbox
        }

        private void displayAssets_SelectedIndexChanged(object sender, EventArgs e)
        {
            string current = displayAssets.SelectedItem.ToString(); // turns the current selected item into a string
            string[] currentID = current.Split('-'); // splits the string up to individual items in an array with [0] being the ID

            for (int i = 0; i < currentID.Length; i++)
            {
                // assigns all text boxes to the current selected item in the listbox
                sysNameBox.Text = currentID[1];
                modelBox.Text = currentID[2];
                manufacturerBox.Text = currentID[3];
                sysTypeBox.Text = currentID[4];
                ipBox.Text = currentID[5];
                dateBox.Text = currentID[6];
                notesBox.Text = currentID[7];
            }
        }
    }
}
