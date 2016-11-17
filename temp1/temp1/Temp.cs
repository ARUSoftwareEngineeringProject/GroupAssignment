using System;
using System.Windows.Forms;
using System.Collections;
using System.Data;


namespace temp1
{
    /// <summary>
    /// class for the main proccesses 
    /// </summary>
    public partial class Temp : Form
    {
        //declaring all the varibles 
        
        int cRight = 1;
        int cLeft = 1;
        bool comboBox3Moved = false;
        bool comboBox4Moved = false;
        int grpSectionPosition = 1;

        public Temp()

        {
            InitializeComponent();
        }

        /// <summary>
        /// load all staff ID into the combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("select * from Staff");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            foreach (DataRow dr in dsPerson.Tables[0].Rows)
            {
                cmbStaffID.Items.Add(dr["StaffID"].ToString());
            }

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



        private void grpSection_Enter(object sender, EventArgs e)
        {

        }

        //clearing the heading to enter heading name
        private void txtHeading_Click(object sender, EventArgs e)
        {
            txtHeading.Clear();
        }

        public void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            //calling templateSave class to use the string 
            TemplateSave temp = new TemplateSave();
            temp.name = txtHeading.Text;
            temp.heading = new ArrayList();
            // every heading
            {
                Heading heading = new Heading();
                heading.headingName = txtHeading.Text;
                heading.comment = new ArrayList();


                // every comments of the current heading 
                {
                    Comments c = new Comments();
                    c.subHeading = txtSubHeading.Text;
                    c.comment = txtComment.Text;
                    //add the comment to array list heading 
                    heading.comment.Add(c);
                }
                temp.heading.Add(heading);
            }

            int staffid = Convert.ToInt32(txtStaffID.Text);
            int staffContact = Convert.ToInt32(txtStaffContact.Text);

            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("insert into Template (StaffID, StaffName, staffContact, TemplateName, Heading, SubHeading, Comment, Position) values(" + staffid + ",'" + txtStaffName.Text + "'," + staffContact + ",'" + txtTemplateName.Text + "', '" + txtHeading.Text + "','" + txtSubHeading.Text + "','" + txtComment.Text + "','" + txtPosition.Text + "')");
            DataSet drPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("insert into Template (StaffID, StaffName, staffContact, TemplateName, Heading, SubHeading, Comment, Position) values(" + staffid + ",'" + txtStaffName.Text + "'," + staffContact + ",'" + txtTemplateName.Text + "', '" + txtHeading.Text + "','" + txtSubHeading2.Text + "', '" + txtComment2.Text + "', '" + txtPosition.Text + "')");
            //DataSet dvPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("insert into Template (StaffID, StaffName, staffContact, TemplateName, Heading, Comment) values(" + staffid + ",'" + txtStaffName.Text + "'," + staffContact + ",'" + txtTemplateName.Text + "', '" + txtHeading.Text + "','" + temp + "')");

            //confirming data is saved
            MessageBox.Show("Datas Saved");

            
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
        /// <summary>
        /// loading the feedback template
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage ss = new HomePage();
            ss.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string comboBoxChange = this.comboBox3.Text;
            if (comboBox3Moved == false)
            {
                if (comboBoxChange == "Move Down")
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
            if (cmbSectionOptions.Text == "Move Down" & grpSectionPosition == 1)
            {
                System.Drawing.Point grpBoxTemp = grpSection2.Location;
                grpSection2.Location = grpSection.Location;
                grpSection.Location = grpBoxTemp;
                grpSectionPosition = 2;
            }
            else if (cmbSectionOptions.Text == "Move Up" & grpSectionPosition == 2)
            {
                System.Drawing.Point grpBoxTemp = grpSection2.Location;
                grpSection2.Location = grpSection.Location;
                grpSection.Location = grpBoxTemp;
                grpSectionPosition = 1;
            }
           
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

        private void cmbStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("select * from Staff where StaffID = '" + cmbStaffID.SelectedItem.ToString() + "'");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            //set up the data grid view
            
           foreach (DataRow dr in dsPerson.Tables[0].Rows)
             {
                 txtStaffID.Text = dr["StaffID"].ToString();
                 txtStaffName.Text = dr["FullName"].ToString();
                 txtStaffContact.Text = dr["Contact"].ToString();
             }

         }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

