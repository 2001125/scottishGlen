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
            dbConnect();
        }

        void dbConnect()
        {
            Console.WriteLine("Hello");

            string connetionString;
            SqlConnection cnn;
            connetionString = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User ID=mssql2001125;Password=Jz7BTyghaF";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

            // MessageBox.Show("Connection Open  !");

            SqlCommand command;
            SqlDataReader dataReader;
            String sql, Output = "";

            sql = "SELECT * FROM assets";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + " - " + dataReader.GetValue(2) + " - " + dataReader.GetValue(3) + " - " + dataReader.GetValue(4) + " - " + dataReader.GetValue(5) + " - " + dataReader.GetValue(6) + " - " + dataReader.GetValue(7) + "\n";
                displayData.Text = Output + "\n";
            }

            // MessageBox.Show(Output);

            cnn.Close();
        } 

        void clearTextBoxes()
        {
            nameBox.Clear();
            modelBox.Clear();
            manufacturerBox.Clear();
            typeBox.Clear();
            ipBox.Clear();
            purchDateBox.Clear();
            noteBox.Clear();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

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
        }
    }
}
