using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace temp1
{
    public partial class Temp : Form
    {
        int cRight = 1;
        int cLeft = 1;
        public Temp()
        {
            InitializeComponent();
        }

        private void lblPosition_Click(object sender, EventArgs e)
        {

        }

        private void txtPosition_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSectionOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tmhun\Source\Repos\GroupAssignment5\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("SELECT ApplicantID, FullName, Address, telephoneNo, Email, DOB FROM Applicants ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'happyTechDatabaseDataSet1.Applicants' table. You can move, or remove it, as needed.
            //this.applicantsTableAdapter1.Fill(this.happyTechDatabaseDataSet1.Applicants);
            // TODO: This line of code loads data into the 'happyTechDatabaseDataSet.Applicants' table. You can move, or remove it, as needed.
            //this.applicantsTableAdapter.Fill(this.happyTechDatabaseDataSet.Applicants);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, MouseEventArgs e)
        {
            
        }

        private void lblStaffID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\tmhun\Source\Repos\GroupAssignment5\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Staff where StaffID='" + lblStaffID.Text + "', FullName='" + lblStaffName.Text + "' and Contact='" + lblContact.Text + "'", con);
            DataTable table = new DataTable();
            sda.Fill(table);
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddNewTextBox2();
            AddNewTextBox();

        }

        TextBox AddNewTextBox2()
        {
            TextBox txt1 = new TextBox();
            this.Controls.Add(txt1);
            txt1.Top = cRight * 25;
            txt1.Left = 150;
            txt1.Text = " " + this.cRight.ToString();
            cRight = cRight + 1;
            return txt1;

        }

        
             TextBox AddNewTextBox()

        {
            TextBox txt = new TextBox();
            this.Controls.Add(txt);
            txt.Top = cLeft * 25;
            txt.Left = 270;
            txt.Text = " " + this.cLeft.ToString();
            cLeft = cLeft + 1;
            return txt;

        }
    }
    }

