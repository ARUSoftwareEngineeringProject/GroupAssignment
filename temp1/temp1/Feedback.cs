﻿using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
using System.Net;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace temp1
{
    /// <summary>
    /// Feedback template
    /// </summary>
    public partial class Feedback : Form
    {

        private static string pdfPath;
        public Feedback()
        {
            InitializeComponent();
        }

        //declare string to store feedback option from database
        private static string select;

        /// <summary>
        /// populating the applicant combobox with required applicant Id
        /// https://vle.anglia.ac.uk/modules/2016/MOD003263/SEM1-F01CAM/Documents/Forms/AllItems.aspx?RootFolder=%2Fmodules%2F2016%2FMOD003263%2FSEM1-F01CAM%2FDocuments%2FWeek%204%20-%20DB&FolderCTID=0x01200071BC415A030994458DC817EAC52D3853&View=%7B5AC15BA6-DE4F-4691-A76D-08391FA3AB70%7D
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
            HomePage ff = new HomePage();
            ff.Show();
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
            DataSet dvPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("Select TemplateName, MAX(TemplateID) as x from Template Group by TemplateName");


            //get the table from the dataset
            DataTable dpPerson = dsPerson.Tables[0];

            foreach (DataRow dr in dvPerson.Tables[0].Rows)
            {
                cmbTempID.Items.Add(dr["TemplateName"].ToString());
            }
        }


        /// <summary>
        /// https://www.youtube.com/watch?v=tm4GHnHw2wc&index=13&list=PLGtk9G6Hf1aEHV-IrHi7g0O5tcRSL__6a
        /// </summary>
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

            //input into Position textbox

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
        // https://www.youtube.com/watch?v=V9c-_pCdUc4&list=PLGtk9G6Hf1aEHV-IrHi7g0O5tcRSL__6a&index=18
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

        //  http://csharp.net-informations.com/communications/csharp-smtp-mail.htm


        private void btnEmail_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("iSkhalawi@gmail.com");
                mail.To.Add(txtEmail.Text);
                mail.Subject = (" Feedback on " + txtTypeOfApplication.Text);
                mail.Body = ("Hello " + txtName.Text + " This is an email regarding the job you have applied for");

                // http://www.coding-issues.com/2012/11/sending-email-with-attachments-from-c.html

                Attachment attachment;
                attachment = new Attachment(pdfPath);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("iSkhalawi@gmail.com", "sultan5566");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        /// <summary>
        /// Method to save the file as pdf 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_savePDF_Click(object sender, EventArgs e)
        {
            //https://www.youtube.com/watch?v=e1uMdAG8L3Y
            //http://stackoverflow.com/questions/30267719/save-pdf-file-with-user-input-filename-itextsharp
            // open the file dialog to name the pdf document and save it in chosen directory
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save as PDF";
            //File type is pdf 
            sfd.Filter = "(*.pdf)|*.pdf";
            //Declaring the directory 
            sfd.InitialDirectory = @"C:\";
            // If statement to open the file and documented after the file is named  
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // Creating the document and the page size to start writing in the file 
                pdfPath = sfd.FileName;
                Document doc = new Document(iTextSharp.text.PageSize.A4);
                PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));

                //To Open the document and add data into it 
                doc.Open();

                // using list to add each Textbox in new line
                iTextSharp.text.List list = new List(List.UNORDERED);
                list.Add(new iTextSharp.text.ListItem(txtName.Text));
                list.Add(txtAddress.Text);
                list.Add(txtEmail.Text);
                list.Add("");
                list.Add(txtTypeOfApplication.Text);
                list.Add("");
                list.Add(txtPosition.Text);
                list.Add("");
                list.Add(txtHeading.Text);
                list.Add("");
                list.Add(select);
                list.Add("");
                list.Add(txtAdditionalComment.Text);

                // To add the above information in pdf file
                doc.Add(list);

                //Closing document 
                doc.Close();
                // Message box to 
                MessageBox.Show("PDF file has been saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}


