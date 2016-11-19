using System;
using System.Windows.Forms;

namespace temp1
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
            

            //set the connection string
            string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\software engineering\Happy Tech\GroupAssignment\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            DatabaseConnection.ConnectionStr = connectionString;

            //Application.Run(new Staff());
            Application.Run(new HomePage());
        }
    }
}
