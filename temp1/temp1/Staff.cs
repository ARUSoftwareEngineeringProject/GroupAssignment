using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace temp1
{
    /// <summary>
    /// class for staff login 
    /// </summary>
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // for exit btn 
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //opening connection to database 
            SqlConnection con =
                new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\software engineering\Happy Tech\GroupAssignment3\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            // checking the login table 
            SqlDataAdapter sda =
                new SqlDataAdapter(
                    "Select Count(*) From Login where LoginID='" + txtStaffID.Text + "' and Password ='" +
                    txtPassword.Text + "'", con);
            DataTable table = new DataTable();       
            
            // if statement for if login information is correct then close login and load template 
           sda.Fill(table);
           if (table.Rows[0][0].ToString() == "1")
            {                   
                this.Hide();
                Temp ss = new Temp();
                ss.Show();
            }
           // if the login information is wrong display the message 
            else
            {
                MessageBox.Show("Please enter the correct credentials. If you have forgotten them, contact IT support");
            }
        }

        
    }
       
}
