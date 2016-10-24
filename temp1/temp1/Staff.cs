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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tmhun\Source\Repos\GroupAssignment5\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where StaffNumber='" + txtStaffID.Text + "' and Password ='" + txtPassword.Text + "'", con);
            DataTable table = new DataTable();
            sda.Fill(table);
            if (table.Rows[0][0].ToString() =="1")
            {
                this.Hide();
                Temp ss = new Temp();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please enter the correct credentials. If you have forgotten them, contact IT support");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStaffID_TextChanged(object sender, EventArgs e)
        {

        }
    }
       
}
