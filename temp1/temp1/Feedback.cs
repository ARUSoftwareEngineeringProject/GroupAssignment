using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;


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
            LoadMain();
        }
        //Call FillApplicant method
        private void cmbApplicantID_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillApplicant();
        }
        //Close Form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Call TempId method
        private void cmbTempID_SelectedIndexChanged(object sender, EventArgs e)
        {
            TempId();
        }
        //Clear heading text box
        private void txtHeading_MouseClick(object sender, MouseEventArgs e)
        {
            txtHeading.Clear();
        }
        //Call Good method
        private void radGood_MouseClick(object sender, MouseEventArgs e)
        {
            Good();
        }
        //Call Poor method
        private void radPoor_MouseClick(object sender, MouseEventArgs e)
        {
            Poor();
        }

        // Call SaveTextFile method
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveTextFile();
        }

        /// <summary>
        /// METHODS
        /// </summary>

        private void LoadMain()
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



        private void FillApplicant()
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

        private void TempId()
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

        
        private void Good()
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("Select Comment From Template where TemplateName ='" + cmbTempID.SelectedItem.ToString() + "'and SubHeading = 'good'");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            foreach (DataRow dr in dsPerson.Tables[0].Rows)
            {
                select = dr["Comment"].ToString();
                MessageBox.Show(" ", select);
            }
        }

       
        private void Poor()
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

        private async void SaveTextFile()
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        await sw.WriteLineAsync(txtName.Text);
                        await sw.WriteLineAsync(txtAddress.Text);
                        await sw.WriteLineAsync(txtEmail.Text);
                        await sw.WriteLineAsync();
                        await sw.WriteLineAsync(txtTypeOfApplication.Text);
                        await sw.WriteLineAsync();
                        await sw.WriteLineAsync(txtPosition.Text);
                        await sw.WriteLineAsync();
                        await sw.WriteLineAsync(txtHeading.Text);
                        await sw.WriteLineAsync();
                        await sw.WriteLineAsync(select);
                        await sw.WriteLineAsync();
                        await sw.WriteLineAsync(txtAdditionalComment.Text);
                        MessageBox.Show("Text file has been saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("iSkhalawi@gmail.com");
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Test Mail";
                mail.Body = "This is for testing SMTP mail from GMAIL";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("iSkhalawi@gmail.com", "sultan5566");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
  

