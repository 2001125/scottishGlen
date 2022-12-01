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
            AddForm addForm = new AddForm();
            addForm.Show();
        }
    }
}
