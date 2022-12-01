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
    public partial class selectForm : Form
    {
        public selectForm()
        {
            InitializeComponent();
        }

        private void hardwareButton_Click(object sender, EventArgs e)
        {
            hardwareForm hardwareForm = new hardwareForm();
            hardwareForm.Show();
        }

        private void softwareButton_Click(object sender, EventArgs e)
        {
            softwareForm softwareForm = new softwareForm();
            softwareForm.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
