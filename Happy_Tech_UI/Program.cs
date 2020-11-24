using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Tech_UI
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

            LogInForm l = new LogInForm();
            if(l.ShowDialog() == DialogResult.OK && l.succesfulLogin == true)
            {
                //If the login is successful run feedback form
                Application.Run(new FeedbackForm());
            }
            
        }
    }
}
