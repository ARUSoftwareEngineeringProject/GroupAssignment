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
    /// Feedback template
    /// </summary>
    public partial class Feedback : Form
    {
        // declaring varibles and connection to database
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Najat\Desktop\SEAssignment\GroupAssignment4\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Feedback()
        {
            InitializeComponent();
        }

        /// <summary>
        /// populating the applicant combobox with required applicant Id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Feedback_Load(object sender, EventArgs e)
        {
            //opening the connection to the database 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //checking applicant table and displaying the applicant ID
            cmd.CommandText = "select * from Applicants";
            cmd.ExecuteNonQuery();
            //proccessing of checking the table 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // displaying each individual applicant ID
            foreach (DataRow dr in dt.Rows)
            {
                cmbApplicantID.Items.Add(dr["ApplicantID"].ToString());
            }
            //closing the connection to database 
            con.Close();

        }

        private void cmbApplicantID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //opening the connection to the database
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            //displaying the applicant ID
            cmd.CommandText = "select * from Applicants where ApplicantID = '" + cmbApplicantID.SelectedItem.ToString() + "'";
            //proccessing of checking the table 
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // fillin applicant information into the text boxes
            foreach (DataRow dr in dt.Rows)
            {
                txtApplicantID.Text = dr["ApplicantID"].ToString();
                txtName.Text = dr["FullName"].ToString();
                txtAddress.Text = dr["Address"].ToString();
                txtTelephoneNo.Text = dr["telephoneNo"].ToString();
                txtEmail.Text = dr["Email"].ToString();
                txtDOB.Text = dr["DOB"].ToString();
                txtTypeOfApplication.Text = dr["typeOfApplication"].ToString();
            }
            //closing the connection to database 
            con.Close();
        }
    }
}
