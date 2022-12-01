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
    public partial class hardwareForm : Form
    {
        public hardwareForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void toAdd_Click(object sender, EventArgs e)
        {
            hardwareAddForm addForm = new hardwareAddForm();
            addForm.Show();
        }

        private void toView_Click(object sender, EventArgs e)
        {
            hardwareViewForm viewForm = new hardwareViewForm();
            viewForm.Show();
        }

        private void toDelete_Click(object sender, EventArgs e)
        {
            hardwareDeleteForm deleteForm = new hardwareDeleteForm();
            deleteForm.Show();
        }

        private void toEdit_Click(object sender, EventArgs e)
        {
            hardwareEditForm editForm = new hardwareEditForm();
            editForm.Show();
        }
    }
}
