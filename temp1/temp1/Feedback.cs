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
    public partial class Feedback : Form
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Najat\Desktop\SEAssignment\GroupAssignment4\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Feedback()
        {
            InitializeComponent();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Applicants";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                cmbApplicantID.Items.Add(dr["ApplicantID"].ToString());
            }
            con.Close();

        }

        private void cmbApplicantID_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Applicants where ApplicantID = '" + cmbApplicantID.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
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
            con.Close();
        }
    }
}
