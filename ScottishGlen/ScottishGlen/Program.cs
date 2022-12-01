using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScottishGlen
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoginForm());

            DialogResult result;

            using (var LoginForm = new LoginForm())
                result = LoginForm.ShowDialog();

            if (result == DialogResult.OK) // check if the login was succesful
            {
                Application.Run(new selectForm()); // run the main form
            }
        }
    }
}
