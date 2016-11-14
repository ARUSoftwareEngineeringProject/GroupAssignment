namespace temp1
{
    partial class Temp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.grpSection = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.txtSubHeading = new System.Windows.Forms.TextBox();
            this.txtSubHeading2 = new System.Windows.Forms.TextBox();
            this.txtComment2 = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.cmbSectionOptions = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.btn_SaveTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.txtStaffContact = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtFeedback = new System.Windows.Forms.Button();
            this.grpSection2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtHeading2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.grpSection.SuspendLayout();
            this.grpSection2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPosition.Location = new System.Drawing.Point(40, 120);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 16);
            this.lblPosition.TabIndex = 1;
            // 
            // btnAddSection
            // 
            this.btnAddSection.Location = new System.Drawing.Point(31, 195);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(75, 38);
            this.btnAddSection.TabIndex = 5;
            this.btnAddSection.Text = "ADD SECTION";
            this.btnAddSection.UseVisualStyleBackColor = true;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            // 
            // grpSection
            // 
            this.grpSection.BackColor = System.Drawing.Color.RosyBrown;
            this.grpSection.Controls.Add(this.comboBox4);
            this.grpSection.Controls.Add(this.comboBox3);
            this.grpSection.Controls.Add(this.txtSubHeading);
            this.grpSection.Controls.Add(this.txtSubHeading2);
            this.grpSection.Controls.Add(this.txtComment2);
            this.grpSection.Controls.Add(this.txtComment);
            this.grpSection.Controls.Add(this.cmbSectionOptions);
            this.grpSection.Controls.Add(this.btnDelete);
            this.grpSection.Controls.Add(this.btnAdd);
            this.grpSection.Controls.Add(this.txtHeading);
            this.grpSection.ForeColor = System.Drawing.Color.Tomato;
            this.grpSection.Location = new System.Drawing.Point(31, 239);
            this.grpSection.Name = "grpSection";
            this.grpSection.Size = new System.Drawing.Size(786, 161);
            this.grpSection.TabIndex = 6;
            this.grpSection.TabStop = false;
            this.grpSection.Enter += new System.EventHandler(this.grpSection_Enter);
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.Beige;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Delete"});
            this.comboBox4.Location = new System.Drawing.Point(641, 111);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(64, 21);
            this.comboBox4.TabIndex = 19;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Beige;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Delete"});
            this.comboBox3.Location = new System.Drawing.Point(641, 74);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(64, 21);
            this.comboBox3.TabIndex = 19;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtSubHeading
            // 
            this.txtSubHeading.Location = new System.Drawing.Point(12, 74);
            this.txtSubHeading.Name = "txtSubHeading";
            this.txtSubHeading.Size = new System.Drawing.Size(149, 20);
            this.txtSubHeading.TabIndex = 16;
            // 
            // txtSubHeading2
            // 
            this.txtSubHeading2.Location = new System.Drawing.Point(12, 112);
            this.txtSubHeading2.Name = "txtSubHeading2";
            this.txtSubHeading2.Size = new System.Drawing.Size(149, 20);
            this.txtSubHeading2.TabIndex = 15;
            // 
            // txtComment2
            // 
            this.txtComment2.Location = new System.Drawing.Point(211, 112);
            this.txtComment2.Name = "txtComment2";
            this.txtComment2.Size = new System.Drawing.Size(414, 20);
            this.txtComment2.TabIndex = 14;
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(211, 74);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(414, 20);
            this.txtComment.TabIndex = 13;
            // 
            // cmbSectionOptions
            // 
            this.cmbSectionOptions.BackColor = System.Drawing.Color.Beige;
            this.cmbSectionOptions.FormattingEnabled = true;
            this.cmbSectionOptions.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Add Heading"});
            this.cmbSectionOptions.Location = new System.Drawing.Point(576, 35);
            this.cmbSectionOptions.Name = "cmbSectionOptions";
            this.cmbSectionOptions.Size = new System.Drawing.Size(146, 21);
            this.cmbSectionOptions.TabIndex = 8;
            this.cmbSectionOptions.SelectedIndexChanged += new System.EventHandler(this.cmbSectionOptions_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(728, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 24);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(178, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.Color.Beige;
            this.txtHeading.Location = new System.Drawing.Point(12, 21);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(155, 20);
            this.txtHeading.TabIndex = 0;
            this.txtHeading.Text = "HEADING";
            this.txtHeading.Click += new System.EventHandler(this.txtHeading_Click);
            // 
            // btn_SaveTemplate
            // 
            this.btn_SaveTemplate.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveTemplate.Location = new System.Drawing.Point(759, 47);
            this.btn_SaveTemplate.Name = "btn_SaveTemplate";
            this.btn_SaveTemplate.Size = new System.Drawing.Size(91, 43);
            this.btn_SaveTemplate.TabIndex = 7;
            this.btn_SaveTemplate.Text = "SAVE TEMPLATE";
            this.btn_SaveTemplate.UseVisualStyleBackColor = true;
            this.btn_SaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(18, 28);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(142, 13);
            this.lblStaffID.TabIndex = 15;
            this.lblStaffID.Text = "PLEASE SELECT STAFF ID";
            // 
            // txtStaffContact
            // 
            this.txtStaffContact.Location = new System.Drawing.Point(402, 133);
            this.txtStaffContact.Name = "txtStaffContact";
            this.txtStaffContact.ReadOnly = true;
            this.txtStaffContact.Size = new System.Drawing.Size(163, 20);
            this.txtStaffContact.TabIndex = 31;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(402, 81);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(163, 20);
            this.txtStaffName.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "STAFF CONTACT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "STAFF NAME";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(402, 37);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(64, 20);
            this.txtStaffID.TabIndex = 35;
            // 
            // txtFeedback
            // 
            this.txtFeedback.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(900, 47);
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(91, 43);
            this.txtFeedback.TabIndex = 37;
            this.txtFeedback.Text = "FEEDBACK FORM";
            this.txtFeedback.UseVisualStyleBackColor = true;
            this.txtFeedback.Click += new System.EventHandler(this.txtFeedback_Click);
            // 
            // grpSection2
            // 
            this.grpSection2.BackColor = System.Drawing.Color.RosyBrown;
            this.grpSection2.Controls.Add(this.comboBox1);
            this.grpSection2.Controls.Add(this.comboBox2);
            this.grpSection2.Controls.Add(this.textBox1);
            this.grpSection2.Controls.Add(this.textBox2);
            this.grpSection2.Controls.Add(this.textBox3);
            this.grpSection2.Controls.Add(this.textBox4);
            this.grpSection2.Controls.Add(this.comboBox5);
            this.grpSection2.Controls.Add(this.button1);
            this.grpSection2.Controls.Add(this.button2);
            this.grpSection2.Controls.Add(this.txtHeading2);
            this.grpSection2.ForeColor = System.Drawing.Color.Tomato;
            this.grpSection2.Location = new System.Drawing.Point(31, 419);
            this.grpSection2.Name = "grpSection2";
            this.grpSection2.Size = new System.Drawing.Size(786, 161);
            this.grpSection2.TabIndex = 38;
            this.grpSection2.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Beige;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Edit",
            "Delete"});
            this.comboBox1.Location = new System.Drawing.Point(641, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.Beige;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Edit",
            "Delete"});
            this.comboBox2.Location = new System.Drawing.Point(641, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(64, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(149, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(211, 112);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(414, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(211, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(414, 20);
            this.textBox4.TabIndex = 13;
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.Color.Beige;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Edit",
            "Delete",
            "Add Heading"});
            this.comboBox5.Location = new System.Drawing.Point(576, 35);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(146, 21);
            this.comboBox5.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(728, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(178, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtHeading2
            // 
            this.txtHeading2.BackColor = System.Drawing.Color.Beige;
            this.txtHeading2.Location = new System.Drawing.Point(12, 21);
            this.txtHeading2.Name = "txtHeading2";
            this.txtHeading2.Size = new System.Drawing.Size(155, 20);
            this.txtHeading2.TabIndex = 0;
            this.txtHeading2.Text = "HEADING";
            this.txtHeading2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtHeading2_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "STAFF ID";
            // 
            // cmbStaffID
            // 
            this.cmbStaffID.FormattingEnabled = true;
            this.cmbStaffID.Location = new System.Drawing.Point(21, 58);
            this.cmbStaffID.Name = "cmbStaffID";
            this.cmbStaffID.Size = new System.Drawing.Size(121, 21);
            this.cmbStaffID.TabIndex = 40;
            this.cmbStaffID.SelectedIndexChanged += new System.EventHandler(this.cmbStaffID_SelectedIndexChanged);
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.cmbStaffID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpSection2);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtStaffContact);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SaveTemplate);
            this.Controls.Add(this.grpSection);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.lblPosition);
            this.Name = "Temp";
            this.Text = "TEMPLATE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpSection.ResumeLayout(false);
            this.grpSection.PerformLayout();
            this.grpSection2.ResumeLayout(false);
            this.grpSection2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.GroupBox grpSection;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox txtSubHeading;
        private System.Windows.Forms.TextBox txtSubHeading2;
        private System.Windows.Forms.TextBox txtComment2;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.ComboBox cmbSectionOptions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.Button btn_SaveTemplate;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.DataGridView dtgStaffDetails;
        //private HappyTechDatabaseDataSet2 happyTechDatabaseDataSet2;
        private System.Windows.Forms.BindingSource staffBindingSource;
        //private HappyTechDatabaseDataSet2TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button txtFeedback;
        private System.Windows.Forms.GroupBox grpSection2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtHeading2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStaffID;
        protected System.Windows.Forms.TextBox txtStaffContact;
        protected System.Windows.Forms.TextBox txtStaffName;
        protected System.Windows.Forms.TextBox txtStaffID;
    }
}

