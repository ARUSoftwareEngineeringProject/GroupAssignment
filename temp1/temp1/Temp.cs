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
        bool comboBox3Moved = false;
        bool comboBox4Moved = false;
        public Temp()

        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\software engineering\Happy Tech\GroupAssignment2\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
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
            ComboBox three = new ComboBox();
            three.BackColor = System.Drawing.Color.Beige;
           three.FormattingEnabled = true;
            three.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Edit",
            "Delete"});
            three.Location = new System.Drawing.Point(641, 74);
           three.Name = "comboBox3";
            three.Size = new System.Drawing.Size(64, 21);
            three.TabIndex = 19;
            three.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);

            groupBox.Controls.Add(this.comboBox3);
            groupBox.Controls.Add(this.txtComment);
            groupBox.Controls.Add(this.txtComment2);
            groupBox.Controls.Add(this.txtSubHeading);
            groupBox.Controls.Add(this.txtSubHeading2);
            ComboBox options = new ComboBox();
            options.BackColor = System.Drawing.Color.Beige;
            options.FormattingEnabled = true;
            options.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Edit",
            "Delete",
            "Add Heading"});
            options.Location = new System.Drawing.Point(576, 35);
            options.Name = "cmbSectionOptions";
            options.Size = new System.Drawing.Size(146, 21);
            options.TabIndex = 8;
            options.SelectedIndexChanged += new System.EventHandler(this.cmbSectionOptions_SelectedIndexChanged);
            
            Button btDel = new Button();
            btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//          this.btDel.Location = new System.Drawing.Point(728, 35);
            btDel.Name = "btnDelete";
            btDel.Size = new System.Drawing.Size(36, 24);
            btDel.TabIndex = 8;
            btDel.Text = "X";
            btDel.UseVisualStyleBackColor = true;
            btDel.Click += new System.EventHandler(this.btnDelete_Click);

            groupBox.Controls.Add(btDel);
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
            if (txtStaffID.Text != "" & txtStaffName.Text != "" & txtStaffContact.Text != "" & txtHeading.Text != "" & txtSubHeading.Text != "" & txtComment.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\software engineering\Happy Tech\GroupAssignment2\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
                SqlCommand command = new SqlCommand();
                command.Connection = con;
                command.CommandType = CommandType.Text;
                con.Open();
                Convert.ToInt32(txtStaffID.Text);
                Convert.ToInt32(txtStaffContact.Text);
                command.CommandText = "insert into Template (StaffID, StaffName, Heading, subHeading, comment) value(" + txtStaffID.Text + ",'" + txtStaffName.Text + "','" + txtStaffContact.Text + "','" + txtHeading.Text + "', '" + txtSubHeading.Text + "', '" + txtComment.Text + "' )";
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
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete a field ? ", "Attention", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ((Button)sender).Parent.Dispose();
                }


            }


        }

        private void txtFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback ss = new Feedback();
            ss.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboBoxChange = this.comboBox3.Text;
            if (comboBox3Moved == false)
            {
                if (comboBoxChange == " Move Down")
                    comboBox3Moved = true;

                System.Drawing.Point headingTemp = txtSubHeading.Location;
                txtSubHeading.Location = txtSubHeading2.Location;
                txtSubHeading2.Location = headingTemp;

                System.Drawing.Point commentTemp = txtComment.Location;
                txtComment.Location = txtComment2.Location;
                txtComment2.Location = commentTemp;
                System.Drawing.Point comboBox3Temp = comboBox3.Location;
                comboBox3.Location = comboBox4.Location;
                comboBox4.Location = comboBox3Temp;

            }

            else if (comboBox3Moved == true)
            {
                if (comboBoxChange == "Move Up")
                {
                    comboBox3Moved = false;
                    System.Drawing.Point headingTemp = txtSubHeading.Location;
                    txtSubHeading.Location = txtSubHeading2.Location;
                    txtSubHeading2.Location = headingTemp;

                    System.Drawing.Point commentTemp = txtComment.Location;
                    txtComment.Location = txtComment2.Location;
                    txtComment2.Location = commentTemp;
                    System.Drawing.Point comboBox3Temp = comboBox3.Location;
                    comboBox3.Location = comboBox4.Location;
                    comboBox4.Location = comboBox3Temp;

                }

            }
            if (comboBoxChange == "Delete")
            {
                comboBox3.Dispose();
                txtComment.Dispose();
                txtSubHeading.Dispose();
            }
        }




        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboBoxChanged = this.comboBox4.Text;
            if (comboBox4Moved == false)
            {
                if (comboBoxChanged == "Delete")
                {
                    comboBox4.Dispose();
                    txtComment2.Dispose();
                    txtSubHeading2.Dispose();
                }
            }
        }
        private void cmbSectionOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

            //string comboBoxChange = this.cmbSectionOptions.Text;
            //if (cmbSectionOptionsMoved == false)
            //{
            //    if (comboBoxChange == "Move Up")
            //    {
            //        cmbSectionOptionsMoved = true;

            //        System.Drawing.Point headingTemp = txtSubHeading.Location;
            //        txtSubHeading.Location = txtSubHeading2.Location;
            //        txtSubHeading2.Location = headingTemp;

            //        System.Drawing.Point commentTemp = txtComment.Location;
            //        txtComment.Location = txtComment2.Location;
            //        txtComment2.Location = commentTemp;
            //        System.Drawing.Point comboBox3Temp = comboBox3.Location;
            //        comboBox3.Location = comboBox4.Location;
            //        comboBox4.Location = comboBox3Temp;

            //    }
            //}
            //else if (comboBox3Moved == true)
            //{
            //    if (comboBoxChange == "Move Down")
            //    {
            //        comboBox3Moved = false;
            //        System.Drawing.Point headingTemp = txtSubHeading.Location;
            //        txtSubHeading.Location = txtSubHeading2.Location;
            //        txtSubHeading2.Location = headingTemp;

            //        System.Drawing.Point commentTemp = txtComment.Location;
            //        txtComment.Location = txtComment2.Location;
            //        txtComment2.Location = commentTemp;
            //        System.Drawing.Point comboBox3Temp = comboBox3.Location;
            //        comboBox3.Location = comboBox4.Location;
            //        comboBox4.Location = comboBox3Temp;

                }

        
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete a field ? ", "Attention", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ((Button)sender).Parent.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GroupBox gb = (GroupBox)(((Button)sender).Parent);
            AddNewTextBox3(gb);
            AddNewTextBox4(gb);
        }

        TextBox AddNewTextBox3(GroupBox gb)
        {
                TextBox txt1 = new TextBox();
                gb.Controls.Add(txt1);
                txt1.Top = cRight * 25;
                txt1.Left = 270;
                txt1.Text = " " + this.cRight.ToString();
                cRight = cRight + 1;
                return txt1;

            }

            TextBox AddNewTextBox4(GroupBox gb)
        {
                TextBox txt = new TextBox();
                gb.Controls.Add(txt);
                txt.Top = cLeft * 25;
                txt.Left = 150;
                txt.Text = " " + this.cLeft.ToString();
                cLeft = cLeft + 1;
                return txt;

            }

        private void txtHeading2_MouseClick(object sender, MouseEventArgs e)
        {
            txtHeading2.Clear();
        }
    }
}  

   