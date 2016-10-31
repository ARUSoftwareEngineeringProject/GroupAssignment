using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using System.Drawing;

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
      
        private void Main_Load(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\software engineering\Happy Tech\GroupAssign2\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Applicants", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
                           
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM Staff ", con);
            DataTable table = new DataTable();
            sda1.Fill(table);
            dtgStaffDetails.DataSource = table;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            GroupBox gb = (GroupBox)(((Button)sender).Parent);
            AddNewTextBox2(gb);
            AddNewTextBox(gb);

        }

        TextBox AddNewTextBox2(GroupBox gb)
        {
            TextBox txt1 = new TextBox();
            gb.Controls.Add(txt1);
            txt1.Top = cRight * 25;
            txt1.Left = 270;
            txt1.Text = " " + this.cRight.ToString();
            cRight = cRight + 1;
            return txt1;

        }

        TextBox AddNewTextBox(GroupBox gb)
        {
            TextBox txt = new TextBox();
           gb.Controls.Add(txt);
           txt.Top = cLeft * 25;
            txt.Left = 150;
            txt.Text = " " + this.cLeft.ToString();
            cLeft = cLeft + 1;
            return txt;

        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            GroupBox groupBox = new GroupBox();
            groupBox.BackColor = System.Drawing.Color.Blue;
            groupBox.Controls.Add(this.comboBox4);
            groupBox.Controls.Add(this.comboBox3);
            groupBox.Controls.Add(this.txtComment);
            groupBox.Controls.Add(this.txtComment2);
            groupBox.Controls.Add(this.txtSubHeading);
            groupBox.Controls.Add(this.txtSubHeading2);
            groupBox.Controls.Add(this.cmbSectionOptions);
            groupBox.Controls.Add(this.btnDelete);
            groupBox.Controls.Add(this.btnAdd);
            groupBox.Controls.Add(this.txtHeading);
            groupBox.ForeColor = System.Drawing.Color.Tomato;
            groupBox.Location = new System.Drawing.Point(34, 273);
            groupBox.Name = "grpSection";
            groupBox.Size = new System.Drawing.Size(786, 161);
            groupBox.TabIndex = 6;
            groupBox.TabStop = false;
            groupBox.Enter += new System.EventHandler(this.grpSection_Enter);
            groupBox.Size = new System.Drawing.Size(786, 161);
            groupBox.ForeColor = System.Drawing.Color.Green;
            groupBox.Location = new System.Drawing.Point(34, 600);
            this.Controls.Add(groupBox);

        }
               

        private void dtgStaffDetails_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtStaffID.Text = dtgStaffDetails.SelectedRows[0].Cells[0].Value.ToString();
            txtStaffName.Text = dtgStaffDetails.SelectedRows[0].Cells[1].Value.ToString();
            txtStaffContact.Text = dtgStaffDetails.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void grpSection_Enter(object sender, EventArgs e)
        {

        }

        private void txtHeading_Click(object sender, EventArgs e)
        {
            txtHeading.Clear();
        }

        private void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            if (txtStaffID.Text!= "" & txtStaffName.Text!="" & txtStaffContact.Text!="" & txtHeading.Text != "" & txtSubHeading.Text != "" & txtComment.Text != "")
            { 
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\software engineering\Happy Tech\GroupAssign2\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                con.Open();
                command.CommandText = "insert into Template (StaffID, StaffName, Heading, subHeading, comment) value('" + txtStaffID.Text + "','" + txtStaffName.Text + "','" + txtStaffContact.Text + "','" + txtHeading.Text + "', '" + txtSubHeading.Text + "', '" + txtComment.Text + "', '" + txtSubHeading2.Text + "', '" + txtComment2.Text + "' )";
                command.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Datas Saved");
      
                txtHeading.Clear();
                txtSubHeading.Clear();
                txtComment.Clear();

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*txtComment.Clear();
            txtComment2.Clear();
            txtHeading.Clear();
            txtSubHeading.Clear();
            txtSubHeading2.Clear();*/

            GroupBox groupBox = new GroupBox();
            if (this.txtComment == null)
            {
                MessageBox.Show("The field is already empty");
            }
            else if (this.txtComment2 == null)
            {
                MessageBox.Show("The field is already empty");
            }
            else if (this.txtSubHeading == null)
            {
                MessageBox.Show("The field is already empty");
            }
            else if (this.txtSubHeading2 == null)
            {
                MessageBox.Show("The field is already empty");
            }
            else
            {
                MessageBox.Show("You have deleted the fields! Please continue.");
                this.txtComment.Clear();
                this.txtComment2.Clear();
                this.txtSubHeading.Clear();
                this.txtSubHeading2.Clear();
            }
            
            
        }

        private void txtFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback ss = new Feedback();
            ss.Show();
        }
    }
    }

