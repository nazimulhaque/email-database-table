using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailDatabaseTable
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
            if (Properties.Settings.Default.DatabaseServerIp.ToString().Trim().Equals("BLANK"))
                Application.Run(new SettingsForm());
            else
                Application.Run(new SendEmailForm());
        }
    }
}
