namespace temp1
{
    partial class Form1
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
            this.lblApplicantNumber = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblStaffNumber = new System.Windows.Forms.Label();
            this.lblTypeOfApplication = new System.Windows.Forms.Label();
            this.cmbApplicationType = new System.Windows.Forms.ComboBox();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbSectionOptions = new System.Windows.Forms.ComboBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.txtApplicationNumber = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.txtStaffNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApplicantNumber
            // 
            this.lblApplicantNumber.AutoSize = true;
            this.lblApplicantNumber.Location = new System.Drawing.Point(40, 63);
            this.lblApplicantNumber.Name = "lblApplicantNumber";
            this.lblApplicantNumber.Size = new System.Drawing.Size(116, 13);
            this.lblApplicantNumber.TabIndex = 0;
            this.lblApplicantNumber.Text = "APPLICANT NUMBER";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(40, 127);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(58, 13);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Text = "POSITION";
            // 
            // lblStaffNumber
            // 
            this.lblStaffNumber.AutoSize = true;
            this.lblStaffNumber.Location = new System.Drawing.Point(368, 63);
            this.lblStaffNumber.Name = "lblStaffNumber";
            this.lblStaffNumber.Size = new System.Drawing.Size(93, 13);
            this.lblStaffNumber.TabIndex = 2;
            this.lblStaffNumber.Text = "STAFF  NUMBER";
            // 
            // lblTypeOfApplication
            // 
            this.lblTypeOfApplication.AutoSize = true;
            this.lblTypeOfApplication.Location = new System.Drawing.Point(368, 128);
            this.lblTypeOfApplication.Name = "lblTypeOfApplication";
            this.lblTypeOfApplication.Size = new System.Drawing.Size(125, 13);
            this.lblTypeOfApplication.TabIndex = 3;
            this.lblTypeOfApplication.Text = "TYPE OF APPLICATION";
            // 
            // cmbApplicationType
            // 
            this.cmbApplicationType.BackColor = System.Drawing.Color.Beige;
            this.cmbApplicationType.FormattingEnabled = true;
            this.cmbApplicationType.Items.AddRange(new object[] {
            "CV",
            "Interview",
            "Technical",
            "Assessment"});
            this.cmbApplicationType.Location = new System.Drawing.Point(514, 127);
            this.cmbApplicationType.Name = "cmbApplicationType";
            this.cmbApplicationType.Size = new System.Drawing.Size(229, 21);
            this.cmbApplicationType.TabIndex = 4;
            this.cmbApplicationType.Text = "Please Select";
            // 
            // btnAddSection
            // 
            this.btnAddSection.Location = new System.Drawing.Point(45, 202);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(134, 38);
            this.btnAddSection.TabIndex = 5;
            this.btnAddSection.Text = "ADD SECTION";
            this.btnAddSection.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Tomato;
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.cmbSectionOptions);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtHeading);
            this.groupBox1.Location = new System.Drawing.Point(57, 297);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(709, 525);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(134, 38);
            this.btnSaveTemplate.TabIndex = 7;
            this.btnSaveTemplate.Text = "SAVE TEMPLATE";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.Color.Beige;
            this.txtHeading.Location = new System.Drawing.Point(12, 21);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(155, 20);
            this.txtHeading.TabIndex = 0;
            this.txtHeading.Text = "HEADING";
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
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(12, 63);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cmbSectionOptions
            // 
            this.cmbSectionOptions.BackColor = System.Drawing.Color.Beige;
            this.cmbSectionOptions.FormattingEnabled = true;
            this.cmbSectionOptions.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Edit",
            "Delete",
            "Add Heading"});
            this.cmbSectionOptions.Location = new System.Drawing.Point(576, 35);
            this.cmbSectionOptions.Name = "cmbSectionOptions";
            this.cmbSectionOptions.Size = new System.Drawing.Size(146, 21);
            this.cmbSectionOptions.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(211, 110);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(414, 20);
            this.textBox9.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(414, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Beige;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Edit",
            "Delete"});
            this.comboBox3.Location = new System.Drawing.Point(641, 109);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(64, 21);
            this.comboBox3.TabIndex = 19;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.Beige;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Move Up",
            "Move Down",
            "Edit",
            "Delete"});
            this.comboBox4.Location = new System.Drawing.Point(641, 146);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(64, 21);
            this.comboBox4.TabIndex = 19;
            // 
            // txtApplicationNumber
            // 
            this.txtApplicationNumber.Location = new System.Drawing.Point(171, 60);
            this.txtApplicationNumber.Name = "txtApplicationNumber";
            this.txtApplicationNumber.Size = new System.Drawing.Size(155, 20);
            this.txtApplicationNumber.TabIndex = 8;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(171, 125);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(155, 20);
            this.txtPosition.TabIndex = 10;
            // 
            // txtStaffNumber
            // 
            this.txtStaffNumber.Location = new System.Drawing.Point(514, 60);
            this.txtStaffNumber.Name = "txtStaffNumber";
            this.txtStaffNumber.Size = new System.Drawing.Size(155, 20);
            this.txtStaffNumber.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(896, 611);
            this.Controls.Add(this.txtStaffNumber);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.txtApplicationNumber);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.cmbApplicationType);
            this.Controls.Add(this.lblTypeOfApplication);
            this.Controls.Add(this.lblStaffNumber);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblApplicantNumber);
            this.Name = "Form1";
            this.Text = "TEMPLATE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicantNumber;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblStaffNumber;
        private System.Windows.Forms.Label lblTypeOfApplication;
        private System.Windows.Forms.ComboBox cmbApplicationType;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.ComboBox cmbSectionOptions;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox txtApplicationNumber;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.TextBox txtStaffNumber;
    }
}

