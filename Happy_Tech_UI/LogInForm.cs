using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Tech_UI
{
    public partial class LogInForm : Form
    {
        public bool succesfulLogin = false;
        public LogInForm()
        {
            InitializeComponent();

            //Initalize database connection
            DatabaseConnection.GetDatabaseConnection();

            //Set dialog result to be OK (Will be used later for login validation)
            button1.DialogResult = DialogResult.OK;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            if (DatabaseConnection._instance.IsValidUser(textBox1.Text, textBox2.Text))
            {
                succesfulLogin = true;
                //Close login dialog
                Close();
            }
            else
                MessageBox.Show("Invalid username or password");
        }
    }
}
