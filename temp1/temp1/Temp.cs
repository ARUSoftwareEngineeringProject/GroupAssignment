using System;
using System.Windows.Forms;
using System.Data;

using System.Drawing;
using System.Collections;
using System.Collections.Generic;

namespace temp1
{
    /// <summary>
    /// class for the main proccesses 
    /// </summary>
    public partial class Temp : Form
    {
        //declaring all the varibles 


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

            btnAdd.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
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

            btDelete.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
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
                "Delete",
                
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
            GroupBox groupBox1 = (GroupBox)(((Button)sender).Parent);

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
                ((Button)sender).Parent.Dispose();
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


        //clearing the heading to enter heading name

        public void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            //get the FlowLayout

            Control[] allControls = this.Controls.Find("groupBox1", true);
            Control[] fl = allControls[0].Controls.Find("flowLayoutPanel1", true);

            //flp contains all the SectionGroupBoxes
            FlowLayoutPanel flp = (FlowLayoutPanel)fl[0];

            //get the  section groupBoxes

            IEnumerator ie = flp.Controls.GetEnumerator();
            while (ie.MoveNext() )
            {
                Control control = (Control)ie.Current;
                if(control.GetType().Name == "GroupBox")
                {
                    GroupBox sectionGb = (GroupBox)control;
                    //b.Controls.
                    MessageBox.Show("Datas Saved");
                }
            }

            //calling templateSave class to use the string 
           //TemplateSave temp = new TemplateSave();
           // temp.name = txtTemplateName.Text;
           // temp.heading = new ArrayList();
           // // every heading
           // {
           //     TextBox txtHeading = AddtxtHeading();
           //     Heading heading = new Heading();
           //     heading.headingName = txtHeading.Text;
           //     heading.comment = new ArrayList();


           //     //every comments of the current heading
           //     {
           //         TextBox neTB = AddNwTb();
           //         TextBox neTB1 = AddNwTb();
           //         Comments c = new Comments();
           //         c.subHeading = neTB.Text;
           //         c.comment = neTB1.Text;
           //         //add the comment to array list heading 
           //         heading.comment.Add(c);
           //     }
           //     temp.heading.Add(heading);
           // }

           // int staffid = Convert.ToInt32(txtStaffID.Text);
           // int staffContact = Convert.ToInt32(txtStaffContact.Text);

           // //fill in the grid 
           // {
           //     TextBox txtHeading = AddtxtHeading();
           //     TextBox neTB = AddNwTb();
           //     TextBox neTB1 = AddNwTb();
           //     DataSet dsPerson =
           // DatabaseConnection.getDBConnectionInstance()
           // .getDataSet(
           // "insert into Template (StaffID, StaffName, staffContact, TemplateName, Heading, SubHeading, Comment, Position) values(" +
           // staffid + ",'" + txtStaffName.Text + "'," + staffContact + ",'" + txtTemplateName.Text + "', '" +
           // txtHeading.Text + "','" + neTB.Text + "','" + neTB1.Text + "','" +
           // txtPosition.Text + "')");
           //     //confirming data is saved
                MessageBox.Show("Datas Saved");
            //}
            

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

        private void btnAddSection_Click(object sender, EventArgs e)
        {
            AddMyGroupBox();

        }



        private void txtHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage tt = new HomePage();
            tt.Show();
        }
    }
}






