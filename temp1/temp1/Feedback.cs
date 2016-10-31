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
        public Feedback()
        {
            InitializeComponent();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'happyTechDatabaseDataSet3.Applicants' table. You can move, or remove it, as needed.
            this.applicantsTableAdapter.Fill(this.happyTechDatabaseDataSet3.Applicants);

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\software engineering\Happy Tech\GroupAssign2\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Applicants", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dtgApplicant.DataSource = dt;
                            

        }

        private void dtgApplicant_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtApplicantID.Text = dtgApplicant.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dtgApplicant.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = dtgApplicant.SelectedRows[0].Cells[2].Value.ToString();
            txtTelephoneNo.Text = dtgApplicant.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = dtgApplicant.SelectedRows[0].Cells[4].Value.ToString();
            txtDOB.Text = dtgApplicant.SelectedRows[0].Cells[5].Value.ToString();
            txtTypeOfApplication.Text = dtgApplicant.SelectedRows[0].Cells[6].Value.ToString();
        }
    }
}
