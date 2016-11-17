using System;
using System.Data;
using System.Windows.Forms;


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
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("Select Count(*) From Login where StaffNumber ='" + txtStaffID.Text + "' and Password ='" +
                    txtPassword.Text + "'");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            if (dtPerson.Rows[0][0].ToString() == "1")
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
