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
           
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\software engineering\Happy Tech\GroupAssignment2\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Applicants", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
                   
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
            //this.Controls.Add(txt1);
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
          //  this.Controls.Add(txt);
            txt.Top = cLeft * 25;
            txt.Left = 150;
            txt.Text = " " + this.cLeft.ToString();
            cLeft = cLeft + 1;
            return txt;

        }

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            //GroupBox select = (GroupBox)CloneObject(grpSection);
            GroupBox groupBox = new GroupBox();
            groupBox.BackColor = System.Drawing.Color.Blue;
            groupBox.Controls.Add(this.comboBox4);
            groupBox.Controls.Add(this.comboBox3);
            /*           this.grpSection.Controls.Add(this.textBox4);
                       this.grpSection.Controls.Add(this.textBox3);
                       this.grpSection.Controls.Add(this.textBox2);
                       this.grpSection.Controls.Add(this.textBox9);
                       this.grpSection.Controls.Add(this.cmbSectionOptions);
                       this.grpSection.Controls.Add(this.btnDelete);
                       this.grpSection.Controls.Add(this.btnAdd);
                       this.grpSection.Controls.Add(this.txtHeading);
                       this.grpSection.ForeColor = System.Drawing.Color.Tomato;
                       this.grpSection.Location = new System.Drawing.Point(34, 273);
                       this.grpSection.Name = "grpSection";
                       this.grpSection.Size = new System.Drawing.Size(786, 161);
                       this.grpSection.TabIndex = 6;
                       this.grpSection.TabStop = false;
                       this.grpSection.Enter += new System.EventHandler(this.grpSection_Enter);
                       */
            groupBox.Size = new System.Drawing.Size(786, 161);
            groupBox.ForeColor = System.Drawing.Color.Green;
            groupBox.Location = new System.Drawing.Point(34, 600);
            this.Controls.Add(groupBox);

        }

        private object CloneObject(object o)
        {
            Type t = o.GetType();
            PropertyInfo[] properties = t.GetProperties();

            Object p = t.InvokeMember("", System.Reflection.BindingFlags.CreateInstance, null, o, null);

            foreach (PropertyInfo pi in properties)
            {
                if (pi.CanWrite)
                {
                    pi.SetValue(p, pi.GetValue(o, null), null);
               
                }
               
            }
            return p;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtApplicantID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtAddress.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtTelephoneNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            txtDOB.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtTypeOfApplication.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            
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

}
    }

