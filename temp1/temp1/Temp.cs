using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Collections.Generic;

namespace temp1
{
    /// <summary>
    /// class for the main proccesses 
    /// </summary>
    public partial class Temp : Form
    {
        //declaring all the variables 

        public List<GroupBox> grpSections = new List<GroupBox>();
        public List<GroupBox> grpBoxList = new List<GroupBox>();


        public Temp()

        {
            InitializeComponent();
        }

        /// <summary>
        /// load all staff ID into the combobox
        /// https://vle.anglia.ac.uk/modules/2016/MOD003263/SEM1-F01CAM/Documents/Forms/AllItems.aspx?RootFolder=%2Fmodules%2F2016%2FMOD003263%2FSEM1-F01CAM%2FDocuments%2FWeek%204%20-%20DB&FolderCTID=0x01200071BC415A030994458DC817EAC52D3853&View=%7B5AC15BA6-DE4F-4691-A76D-08391FA3AB70%7D
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Load(object sender, EventArgs e)
        {
            try
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
            catch (Exception z)
            {
                Console.WriteLine("Error. Please Contact IT support", z);
                MessageBox.Show("Unable to connect");
            }


        }


        // Method to add the  add button

        private Button addAddButton()

        {
            // Declare new button 
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

        // Add the delete button method 

        private Button addDeleteButton()
        {
            // Declare a new button 

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
            // declare new text box  

            TextBox neTB = new TextBox();

            // Define the size of the text box
            neTB.Size = new Size(80, 50);

            TextBox neTB1 = new TextBox();
            neTB1.Size = new Size(300, 50);

            // declare new combo box 
            ComboBox neCB = new ComboBox();

            // define the size of the combo box and set its properties 

            neCB.Size = new Size(70, 50);
            neCB.Items.AddRange(new object[]
            {
                "Move Up",
                "Move Down",
                "Delete",

            });

            // create the new group box that stores the subheading, comment and the combobox

            /*
           // Declare a new group box
           */
       
            GroupBox groupBoxComment = new GroupBox();

            /*
           // Declare a new flow lay out panel   
           */

            FlowLayoutPanel flp = new FlowLayoutPanel();
            flp.FlowDirection = FlowDirection.LeftToRight;

            grpSections.Add(groupBoxComment);
            neCB.SelectedIndexChanged += delegate (object sender, EventArgs args)
            {
                neCB_SelectedIndexChanged(sender, args, neCB, groupBoxComment, groupBox);
            };
            
            // the flow layout panel is adding the controls

            flp.Controls.Add(neTB);
            flp.Controls.Add(neTB1);
            flp.Controls.Add(neCB);

            // setting flow layout panel properties
            flp.Dock = DockStyle.Fill;
            flp.AutoSize = true;

            // group box is adding the controls 
            groupBoxComment.Controls.Add(flp);
            groupBox.Controls.Add(groupBoxComment);

            // group box properties 
            groupBox.AutoSize = true;
            groupBoxComment.Size = new Size(100, 50);
            groupBoxComment.AutoSize = true;
            groupBoxComment.Location = new Point(20, 50);

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // identify the sendr and get the button from the sender 
            GroupBox groupBox1 = (GroupBox)(((Button)sender).Parent);

            grpBoxList.Add(groupBox1);

            DialogResult result = MessageBox.Show("Do you want to add additional sections ?", "Message",
                MessageBoxButtons.YesNo);

            // if statement to check the user input 

            if (result == DialogResult.Yes)

            {
                AddNwTb(groupBox1);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete a field ? ", "Attention",
                MessageBoxButtons.YesNo);

            // If statement to check the user input 

            if (dialogResult == DialogResult.Yes)
            {
                ((Button)sender).Parent.Dispose();
            }
        }


        // Add Combobox method 

        private ComboBox addComboBoxBox3()
        {

            /*
           // Declare a new combo box and set its properties  
           */

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
            // Declare a new text box and set its properties
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
            /*
            // Declare a new group box and set its properties  
            */

            GroupBox groupBox1 = new GroupBox();
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Size = new Size(650, 150); //??

            // declare the button from the button method 
            Button btnAdd = addAddButton();
            Button btnDelete = addDeleteButton();


            // declare the combo box from the combo box method 
            ComboBox cmbSectionOptions = addComboBoxBox3();

            // declare the text box  from the text box method 
            TextBox txtHeading = AddtxtHeading();



            // Group box is adding the controls 

            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(cmbSectionOptions);
            groupBox1.Controls.Add(txtHeading);

            // Flow lay out panel  controls is adding the group box 
            flowLayoutPanel1.Controls.Add(groupBox1);

            // directing the flow lay out panel to be starting from top to down 
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;

        }



        //saving all the data values into the Template table in Database

        public void btnSaveTemplate_Click(object sender, EventArgs e)
        {
            try
            {
                int i = 0;
                bool validData = false;

                foreach (Control control in groupBox1.Controls)
                {
                    if (control is FlowLayoutPanel && control.HasChildren)
                    {
                        foreach (Control ctrl in control.Controls)
                        {
                            if (ctrl is GroupBox && ctrl.HasChildren)
                            {
                                foreach (Control ctrl2 in control.Controls)
                                {
                                    if (ctrl2 is GroupBox && ctrl2.HasChildren)
                                    {
                                        foreach (Control tbox in ctrl2.Controls)
                                        {
                                            if (tbox is TextBox)
                                            {

                                                foreach (Control contrl in this.Controls)
                                                {
                                                    if (contrl.Name == ("Textbox" + i.ToString()))
                                                    {
                                                        contrl.Text = "tbox";
                                                    }

                                                }
                                                validData &= !string.IsNullOrWhiteSpace(tbox.Text);

                                                int staffid = Convert.ToInt32(txtStaffID.Text);
                                                int staffContact = Convert.ToInt32(txtStaffContact.Text);

                                                DatabaseConnection.getDBConnectionInstance()
                                                .getDataSet("insert into Template (StaffID, StaffName, staffContact, TemplateName, Position, Heading, SubHeading, Comment) values(" +
                                               staffid + ",'" + txtStaffName.Text + "'," + staffContact + ",'" + txtTemplateName.Text + "','" + txtPosition.Text + "','" +
                                                tbox.Text + "','" + tbox.Text + "','" + tbox.Text + "')");
                                                MessageBox.Show("The Data has been saved");

                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            
            }
            catch (Exception z)
            {
                Console.WriteLine("Error. Please Contact IT support", z);
                MessageBox.Show("Unable to save");
            }

        }

        //https://www.youtube.com/watch?v=tm4GHnHw2wc&index=13&list=PLGtk9G6Hf1aEHV-IrHi7g0O5tcRSL__6a
        //https://vle.anglia.ac.uk/modules/2016/MOD003263/SEM1-F01CAM/Documents/Forms/AllItems.aspx?RootFolder=%2Fmodules%2F2016%2FMOD003263%2FSEM1-F01CAM%2FDocuments%2FWeek%204%20-%20DB&FolderCTID=0x01200071BC415A030994458DC817EAC52D3853&View=%7B5AC15BA6-DE4F-4691-A76D-08391FA3AB70%7D
        private void cmbStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("select * from Staff where StaffID = '" + cmbStaffID.SelectedItem.ToString() + "'");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            //fill in the particular textboxes with values from corresponding Table Columns
            //https://www.youtube.com/watch?v=EvnjxYpwbvc&index=14&list=PLGtk9G6Hf1aEHV-IrHi7g0O5tcRSL__6a
            foreach (DataRow dr in dsPerson.Tables[0].Rows)
            {
                txtStaffID.Text = dr["StaffID"].ToString();
                txtStaffName.Text = dr["FullName"].ToString();
                txtStaffContact.Text = dr["Contact"].ToString();
            }

        }


        private void neCB_SelectedIndexChanged(object sender, EventArgs e, ComboBox neCB, GroupBox groupBoxComment, GroupBox groupBox)
        {
            //ComboBox neCB = null;
            if (neCB.Text == "Move Down")
            {
                try
                {

                    int grpBoxIndex = grpSections.FindIndex(x => x == groupBoxComment);
                    if (grpBoxIndex + 1 <= grpSections.Count - 1)
                    {
                        // finding the location of the selected group box in the list of group boxes


                        Control firstGB = grpSections[grpBoxIndex].Parent;
                        grpSections[grpBoxIndex].Parent.Controls.Remove(grpSections[grpBoxIndex]);

                        Control secondGB = grpSections[grpBoxIndex + 1].Parent;
                        grpSections[grpBoxIndex + 1].Parent.Controls.Remove(grpSections[grpBoxIndex + 1]);


                        //swapping the index of the group box in the list itself 
                        GroupBox grpBoxTemp = grpSections[grpBoxIndex + 1];
                        grpSections[grpBoxIndex + 1] = grpSections[grpBoxIndex];
                        grpSections[grpBoxIndex] = grpBoxTemp;

                        firstGB.Controls.Add(grpSections[grpBoxIndex]);

                        secondGB.Controls.Add(grpSections[grpBoxIndex + 1]);
                    }
                }
                // catches the error if the group box selected was the last in the list whilst attempting to move it down
                catch (ArgumentOutOfRangeException) { }


            }
            else if (neCB.Text == "Move Up")
            {
                try
                {
                    // finding the location of the selected group box in the list of group boxes
                    int grpBoxIndex = grpSections.FindIndex(x => x == groupBoxComment);
                    if (grpBoxIndex - 1 >= 0)
                    {


                        Control firstGB = grpSections[grpBoxIndex].Parent;
                        grpSections[grpBoxIndex].Parent.Controls.Remove(grpSections[grpBoxIndex]);

                        Control secondGB = grpSections[grpBoxIndex - 1].Parent;
                        grpSections[grpBoxIndex - 1].Parent.Controls.Remove(grpSections[grpBoxIndex - 1]);

                        //swapping the index of the group box in the list itself 
                        GroupBox grpBoxTemp = grpSections[grpBoxIndex - 1];
                        grpSections[grpBoxIndex - 1] = grpSections[grpBoxIndex];
                        grpSections[grpBoxIndex] = grpBoxTemp;

                        firstGB.Controls.Add(grpSections[grpBoxIndex]);

                        secondGB.Controls.Add(grpSections[grpBoxIndex - 1]);
                    }
                }

                // catches the error if the group box selected was the last in the list whilst attempting to move it down
                catch (ArgumentOutOfRangeException) { }


            }
        }


        private void btnAddSection_Click(object sender, EventArgs e)
        {
            // calling the method to add the main groupBox 

            AddMyGroupBox();


        }


        //Link to return to the Homepage form
        private void txtHomePage_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage tt = new HomePage();
            tt.Show();
        }

        private void flowLayoutPanel1_paint(object sender, EventArgs e)
        {

        }
    }
   
}






