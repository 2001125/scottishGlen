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
    public partial class softwareViewForm : Form
    {
        public softwareViewForm()
        {
            InitializeComponent();
            BindGrid();
        }

        private void BindGrid()
        {
            string constring = @"Data Source=tolmount.abertay.ac.uk;Initial Catalog=mssql2001125;User id=mssql2001125;password=Jz7BTyghaF";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM software", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            viewSoftwareGrid.DataSource = dt;
                        }
                    }
                }
            }
        }

        private void softwareViewForm_Load(object sender, EventArgs e)
        {

        }
    }
}
