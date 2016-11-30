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

        //https://msdn.microsoft.com/en-us/library/ms157894(v=vs.110).aspx
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // for exiting the whole application 
            Application.Exit();
        }
        //https://www.youtube.com/watch?v=tcmmCcMs8yU&index=6&list=PLGtk9G6Hf1aEHV-IrHi7g0O5tcRSL__6a
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
