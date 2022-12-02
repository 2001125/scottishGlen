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
    public partial class softwareForm : Form
    {
        public softwareForm()
        {
            InitializeComponent();
        }

        private void softwareForm_Load(object sender, EventArgs e)
        {
            // scan device to get the current os
            // add it to the database
            // when a certain os is clicked on, show user what hardware devices are currently using it
            // probably just in one form to view, add, edit and delete
            // for adding, don't allow manual add just scan system
            // two tables (probably listboxes), one for the software and then when one is selected the other box shows the hardware using it
            // have field in hardware database with foreign key showing what os it is using
            string test; 
        }
    }
}
