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
    public partial class softwareAddForm : Form
    {
        public softwareAddForm()
        {
            InitializeComponent();
            dbConnect(); // runs this to immediately display the records on the progam loading
        }

        void dbConnect() // function to connection to the database and display all records
        {
            displayListData.Items.Clear(); // clears the list so new data is shown without old data repeating itself

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
                displayListData.Items.Add(Output); // add current Output to the list box to display
                Output = ""; // clear Output so old Output isn't displayed again
            } // while loop

            cnn.Close(); // close connection
        } // dbConnect()

        void addData()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF"; // details to connect to the mssql db
            cnn = new SqlConnection(connetionString); // initialise connection with the login details
            cnn.Open(); // open connection 

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            // inserting all the values from the text box to the database in an sql statement
            sql = "INSERT INTO software VALUES('" + osBox.Text + "', '" + versionBox.Text + "', '" + manufacturerBox.Text + "'); ";
            command = new SqlCommand(sql, cnn); // initialise the sql command

            adapter.InsertCommand = new SqlCommand(sql, cnn); // start command
            adapter.InsertCommand.ExecuteNonQuery(); // execute command

            command.Dispose(); // dispose of the sql command
            cnn.Close(); // close connection
        } // addData()


        void clearTextBoxes() // function to clear all the text boxes after an asset is added 
        {
            osBox.Clear();
            versionBox.Clear();
            manufacturerBox.Clear();
        } // clearTextBoxes()

        private void addDataButton_Click(object sender, EventArgs e)
        {
            addData(); // run the addData function

            clearTextBoxes(); // clears all the text boxes so more data can easily be added
            dbConnect(); // refreshes the list to show new data
        }

        private void scanSys_Click(object sender, EventArgs e)
        {
            var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                                    select x.GetPropertyValue("Caption")).FirstOrDefault();
            
            string version = Environment.OSVersion.Version.ToString();


            MessageBox.Show("Computer Name: " + name + "\nModel: " + version + "\nManufacturer: Windows");

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF"; // details to connect to the mssql db
            cnn = new SqlConnection(connetionString); // initialise connection with the login details
            cnn.Open(); // open connection 

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";

            // inserting all the values from the text box to the database in an sql statement
            sql = "INSERT INTO software VALUES('" + name + "', '" + version + "', 'Windows'); ";
            command = new SqlCommand(sql, cnn); // initialise the sql command

            adapter.InsertCommand = new SqlCommand(sql, cnn); // start command
            adapter.InsertCommand.ExecuteNonQuery(); // execute command

            command.Dispose(); // dispose of the sql command
            cnn.Close(); // close connection

            dbConnect(); // refresh the list box
        }

        private void softwareAddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
