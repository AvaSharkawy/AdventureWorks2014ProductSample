using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnventureWorks2014Sample
{
    static class Program
    {
        public static string DataSource { get; set; }
        public static string DatabaseName { get; set; }
        public static string UserId { get; set; }
        public static string Password { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataSource = "<DATA SOURCE HERE>";
            DatabaseName = "<DATABASE NAME HERE>";
            // If you want to use Integrated Security then leave userId and Password null
            UserId = null;
            Password = null;

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainDashboard());
        }
    }
}
