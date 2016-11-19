using System;
using System.Data;
using System.Windows.Forms;


namespace temp1
{
    /// <summary>
    /// Feedback template
    /// </summary>
    public partial class Feedback : Form
    {
               
        public Feedback()
        {
            InitializeComponent();
        }

        //declare string to store feedback option from database
        private static string select;

        /// <summary>
        /// populating the applicant combobox with required applicant Id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Feedback_Load(object sender, EventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("select * from Applicants");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            foreach (DataRow dr in dsPerson.Tables[0].Rows)
            {
                cmbApplicantID.Items.Add(dr["ApplicantID"].ToString());
            }

            //fill in the grid 
            DataSet dvPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("select * from Template");


            //get the table from the dataset
            DataTable dpPerson = dsPerson.Tables[0];

            foreach (DataRow dr in dvPerson.Tables[0].Rows)
            {
                cmbTempID.Items.Add(dr["TemplateName"].ToString());
            }
        }

        private void cmbApplicantID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("select * from Applicants where ApplicantID = '" + cmbApplicantID.SelectedItem.ToString() + "'");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            //set up the data grid view

            foreach (DataRow dr in dsPerson.Tables[0].Rows)
            {
                txtApplicantID.Text = dr["ApplicantID"].ToString();
                txtName.Text = dr["FullName"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtTelephoneNo.Text = dr["telephoneNo"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtDOB.Text = dr["DOB"].ToString();
                txtTypeOfApplication.Text = dr["typeOfApplication"].ToString();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
         }
       
        private void cmbTempID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("select * from Template where TemplateName = '" + cmbTempID.SelectedItem.ToString() + "'");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            //set up the data grid view

            foreach (DataRow dr in dsPerson.Tables[0].Rows)
            {
                txtPosition.Text = dr["Position"].ToString();
            }

        }

        private void txtHeading_MouseClick(object sender, MouseEventArgs e)
        {
            txtHeading.Clear();
        }

        private void radGood_MouseClick(object sender, MouseEventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("Select Comment From Template where TemplateName ='" + cmbTempID.SelectedItem.ToString() + "'and SubHeading = 'good'");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            foreach (DataRow dr in dsPerson.Tables[0].Rows)
            {
                select = dr["Comment"].ToString();
                MessageBox.Show(" ",select);
            }

        }

        private void radPoor_MouseClick(object sender, MouseEventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("Select  Comment From Template where TemplateName ='" + cmbTempID.SelectedItem.ToString() + "'and SubHeading = 'poor'");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            foreach (DataRow dr in dsPerson.Tables[0].Rows)
            {
                select = dr["Comment"].ToString();
                MessageBox.Show(" ", select);
            }
        }
    }
}
