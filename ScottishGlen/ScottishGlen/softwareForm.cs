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

        private void toView_Click(object sender, EventArgs e)
        {
            softwareViewForm viewForm = new softwareViewForm();
            viewForm.Show();
        }

        private void toAdd_Click(object sender, EventArgs e)
        {
            softwareAddForm addForm = new softwareAddForm();
            addForm.Show();
        }

        private void toEdit_Click(object sender, EventArgs e)
        {
            softwareEditForm editForm = new softwareEditForm();
            editForm.Show();
        }
    }
}
