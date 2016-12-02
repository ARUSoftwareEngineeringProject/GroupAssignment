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

            //https://vle.anglia.ac.uk/modules/2016/MOD003263/SEM1-F01CAM/Documents/Forms/AllItems.aspx?RootFolder=%2Fmodules%2F2016%2FMOD003263%2FSEM1-F01CAM%2FDocuments%2FWeek%204%20-%20DB&FolderCTID=0x01200071BC415A030994458DC817EAC52D3853&View=%7B5AC15BA6-DE4F-4691-A76D-08391FA3AB70%7D
            //set the connection string
            string connectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Najat\Desktop\SEAssignment\GroupAssignment13\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            DatabaseConnection.ConnectionStr = connectionString;

            //Start on The Login form
            //Application.Run(new Staff());
            Application.Run(new HomePage());

        }
    }
}
