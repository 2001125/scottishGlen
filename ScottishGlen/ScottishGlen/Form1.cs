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

namespace ScottishGlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dbConnect(); // runs this to immediately display the records on the progam loading
        } // Form1()

        void dbConnect() // function to connection to the database and display all records
        {
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
                displayListData.Items.Add(Output); // add current Output to the list box to display
                Output = ""; // clear Output so old Output isn't displayed again
            } // while loop

            cnn.Close(); // close connection
        } // dbConnect()

        void clearTextBoxes() // function to clear all the text boxes after an asset is added 
        {
            nameBox.Clear();
            modelBox.Clear();
            manufacturerBox.Clear();
            typeBox.Clear();
            ipBox.Clear();
            purchDateBox.Clear();
            noteBox.Clear();
        } // clearTextBoxes()
        
        private void Form1_Load(object sender, EventArgs e)
        {

        } // Form1_load

        private void addDataButton_Click(object sender, EventArgs e)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql="";

            sql = "INSERT INTO assets VALUES('" + nameBox.Text + "', '" + modelBox.Text + "', '" + manufacturerBox.Text + "', '" + typeBox.Text + "', '" + ipBox.Text + "', '" + purchDateBox.Text + "', '" + noteBox.Text + "'); ";
            command = new SqlCommand(sql, cnn);

            adapter.InsertCommand = new SqlCommand(sql, cnn);
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
            cnn.Close();

            clearTextBoxes();
            dbConnect();
        } // addDataButton_Click()
    } // Form1 Class
}
