using System;
using System.Windows.Forms;
using System.Collections;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace temp1
{
    /// <summary>
    /// class for the main proccesses 
    /// </summary>
    public partial class Temp : Form
    {
        //declaring all the varibles 

        FlowLayoutPanel flowLayoutPanel1 = new FlowLayoutPanel();
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


        // Method to add the button

        private Button addAddButton()

        {

            Button btnAdd = new Button();


            // Add button location and properties

            btnAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte) (0)));
            btnAdd.Location = new Point(120, 15);
            btnAdd.Name = "btnDelete";
            btnAdd.Size = new Size(20, 20);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += new EventHandler(this.btnAdd_Click);
            return btnAdd;
        }


        private Button addDeleteButton()
        {

            Button btDelete = new Button();


            // Delete button location and properties

            btDelete.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte) (0)));
            btDelete.Location = new Point(500, 20);
            btDelete.Name = "btnDelete";
            btDelete.Size = new Size(20, 20);
            btDelete.TabIndex = 8;
            btDelete.Text = "X";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += new EventHandler(this.btnDelete_Click);
            return btDelete;
        }


        /*
         * Add a new groupbox that stores the comments to the section group box (the blue one)
         * GroupBox parameter is the section group box (the blue one)
         */

        private void AddNwTb(GroupBox groupBox)
        {
            TextBox neTB = new TextBox();
            neTB.Size = new Size(80, 50);

            TextBox neTB1 = new TextBox();
            neTB1.Size = new Size(300, 50);

            ComboBox neCB = new ComboBox();
            neCB.Size = new Size(70, 50);

            neCB.BackColor = Color.Red;
            neCB.Items.AddRange(new object[]
            {
                "Move Up",
                "Move Down",
                "Edit",
                "Delete",
                "Add Heading"
            });

            // create the new group box that stores the subheading, comment and the combobox
            GroupBox groupBoxComment = new GroupBox();
            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.FlowDirection = FlowDirection.LeftToRight;

            //flp.WrapContents = false;
            flp.Controls.Add(neTB);
            flp.Controls.Add(neTB1);
            flp.Controls.Add(neCB);

            flp.Dock = DockStyle.Fill;
            flp.AutoSize = true;


            //flp.Size = new Size(650,150);
            groupBoxComment.Controls.Add(flp);
            groupBox.Controls.Add(groupBoxComment);
            //flp.WrapContents = false;


            //groupBoxComment.Controls.Add(flp);
            groupBoxComment.Size = new Size(100, 50);
            groupBoxComment.AutoSize = true;
            groupBoxComment.Location = new Point(20, 50);


            //groupBox.Controls.Add(groupBoxComment);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GroupBox groupBox1 = (GroupBox) (((Button) sender).Parent);

            DialogResult result = MessageBox.Show("Do you want to add additional sections ?", "Message",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)

            {
                AddNwTb(groupBox1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete a field ? ", "Attention",
                MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ((Button) sender).Parent.Dispose();
            }
        }


        // Add Combobox method 

        private ComboBox addComboBoxBox3()
        {
            ComboBox cmbSectionOptions = new ComboBox();

            cmbSectionOptions.BackColor = Color.Beige;
            cmbSectionOptions.FormattingEnabled = true;
            cmbSectionOptions.Items.AddRange(new object[]

            {
                "Move Up",
                "Move Down",

            });

            cmbSectionOptions.Location = new Point(550, 20);
            cmbSectionOptions.Name = "cmbSectionOptions";
            cmbSectionOptions.Size = new Size(70, 50);

            return cmbSectionOptions;
        }

        /*
       // Method to add the text box 
       */

        private TextBox AddtxtHeading()
        {
            /*
            // Declear a new text box 
            */
            TextBox txtHeading = new TextBox();
            txtHeading.Location = new Point(6, 15);
            txtHeading.Size = new Size(80, 50);
            return txtHeading;
        }


        /*
       // Method to add the Group box 
       */

        private void AddMyGroupBox()

        {

            GroupBox groupBox1 = new GroupBox();
            groupBox1.BackColor = Color.Blue;
            groupBox1.Size = new Size(650, 150); //??
            Button btnAdd = addAddButton();
            ComboBox cmbSectionOptions = addComboBoxBox3();
            TextBox txtHeading = AddtxtHeading();
            Button btnDelete = addDeleteButton();


            //AddNwTb(groupBox1);


            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(cmbSectionOptions);
            groupBox1.Controls.Add(txtHeading);
            flowLayoutPanel1.Controls.Add(groupBox1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

        }



        private void button1_Click(object sender, EventArgs e)
        {
            AddMyGroupBox();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
            DataSet dsPerson =
                DatabaseConnection.getDBConnectionInstance()
                    .getDataSet(
                        "insert into Template (StaffID, StaffName, staffContact, TemplateName, Heading, SubHeading, Comment, Position) values(" +
                        staffid + ",'" + txtStaffName.Text + "'," + staffContact + ",'" + txtTemplateName.Text + "', '" +
                        txtHeading.Text + "','" + txtSubHeading.Text + "','" + txtComment.Text + "','" +
                        txtPosition.Text + "')");
            DataSet drPerson =
                DatabaseConnection.getDBConnectionInstance()
                    .getDataSet(
                        "insert into Template (StaffID, StaffName, staffContact, TemplateName, Heading, SubHeading, Comment, Position) values(" +
                        staffid + ",'" + txtStaffName.Text + "'," + staffContact + ",'" + txtTemplateName.Text + "', '" +
                        txtHeading.Text + "','" + txtSubHeading2.Text + "', '" + txtComment2.Text + "', '" +
                        txtPosition.Text + "')");
            //DataSet dvPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("insert into Template (StaffID, StaffName, staffContact, TemplateName, Heading, Comment) values(" + staffid + ",'" + txtStaffName.Text + "'," + staffContact + ",'" + txtTemplateName.Text + "', '" + txtHeading.Text + "','" + temp + "')");

            //confirming data is saved
            MessageBox.Show("Datas Saved");


        }
    }
}


//private void btnDelete_Click(object sender, EventArgs e)
//{

//    GroupBox groupBox = new GroupBox();
//    if (this.txtComment == null)
//    {
//        MessageBox.Show("The field is already empty");
//    }
//    else if (this.txtComment2 == null)
//    {
//        MessageBox.Show("The field is already empty");
//    }
//    else if (this.txtSubHeading == null)
//    {
//        MessageBox.Show("The field is already empty");
//    }
//    else if (this.txtSubHeading2 == null)
//    {
//        MessageBox.Show("The field is already empty");
//    }
//    else
//    {
//        DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete a field ? ", "Attention", MessageBoxButtons.YesNo);
//        if (dialogResult == DialogResult.Yes)
//        {
//            ((Button)sender).Parent.Dispose();
//        }


//    }




/// <summary>
/// loading the feedback template
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>

//        private void txtFeedback_Click(object sender, EventArgs e)
//        {
//            this.Hide();
//            HomePage ss = new HomePage();
//            ss.Show();
//        }

//        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            string comboBoxChange = this.comboBox3.Text;
//            if (comboBox3Moved == false)
//            {
//                if (comboBoxChange == "Move Down")
//                    comboBox3Moved = true;

//                System.Drawing.Point headingTemp = txtSubHeading.Location;
//                txtSubHeading.Location = txtSubHeading2.Location;
//                txtSubHeading2.Location = headingTemp;

//                System.Drawing.Point commentTemp = txtComment.Location;
//                txtComment.Location = txtComment2.Location;
//                txtComment2.Location = commentTemp;
//                System.Drawing.Point comboBox3Temp = comboBox3.Location;
//                comboBox3.Location = comboBox4.Location;
//                comboBox4.Location = comboBox3Temp;

//            }

//            else if (comboBox3Moved == true)
//            {
//                if (comboBoxChange == "Move Up")
//                {
//                    comboBox3Moved = false;
//                    System.Drawing.Point headingTemp = txtSubHeading.Location;
//                    txtSubHeading.Location = txtSubHeading2.Location;
//                    txtSubHeading2.Location = headingTemp;

//                    System.Drawing.Point commentTemp = txtComment.Location;
//                    txtComment.Location = txtComment2.Location;
//                    txtComment2.Location = commentTemp;
//                    System.Drawing.Point comboBox3Temp = comboBox3.Location;
//                    comboBox3.Location = comboBox4.Location;
//                    comboBox4.Location = comboBox3Temp;

//                }

//            }
//            if (comboBoxChange == "Delete")
//            {
//                comboBox3.Dispose();
//                txtComment.Dispose();
//                txtSubHeading.Dispose();
//            }
//        }




//        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            string comboBoxChanged = this.comboBox4.Text;
//            if (comboBox4Moved == false)
//            {
//                if (comboBoxChanged == "Delete")
//                {
//                    comboBox4.Dispose();
//                    txtComment2.Dispose();
//                    txtSubHeading2.Dispose();
//                }
//            }
//        }
//        private void cmbSectionOptions_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            if (cmbSectionOptions.Text == "Move Down" & grpSectionPosition == 1)
//            {
//                System.Drawing.Point grpBoxTemp = grpSection2.Location;
//                grpSection2.Location = grpSection.Location;
//                grpSection.Location = grpBoxTemp;
//                grpSectionPosition = 2;
//            }
//            else if (cmbSectionOptions.Text == "Move Up" & grpSectionPosition == 2)
//            {
//                System.Drawing.Point grpBoxTemp = grpSection2.Location;
//                grpSection2.Location = grpSection.Location;
//                grpSection.Location = grpBoxTemp;
//                grpSectionPosition = 1;
//            }

//        }






//        private void txtHeading2_MouseClick(object sender, MouseEventArgs e)
//        {
//            txtHeading2.Clear();
//        }

//        private void cmbStaffID_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            //fill in the grid 
//            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("select * from Staff where StaffID = '" + cmbStaffID.SelectedItem.ToString() + "'");


//            //get the table from the dataset
//            DataTable dtPerson = dsPerson.Tables[0];

//            //set up the data grid view

//           foreach (DataRow dr in dsPerson.Tables[0].Rows)
//             {
//                 txtStaffID.Text = dr["StaffID"].ToString();
//                 txtStaffName.Text = dr["FullName"].ToString();
//                 txtStaffContact.Text = dr["Contact"].ToString();
//             }

//         }

//        private void textBox5_TextChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}


