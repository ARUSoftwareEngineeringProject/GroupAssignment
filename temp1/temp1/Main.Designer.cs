namespace temp1
{
    partial class Main
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
            this.btnAddSection = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.cmbSectionOptions = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.txtApplicationNumber = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblApplicantNumber
            // 
            this.lblApplicantNumber.AutoSize = true;
            this.lblApplicantNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicantNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApplicantNumber.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblApplicantNumber.Location = new System.Drawing.Point(40, 63);
            this.lblApplicantNumber.Name = "lblApplicantNumber";
            this.lblApplicantNumber.Size = new System.Drawing.Size(110, 16);
            this.lblApplicantNumber.TabIndex = 0;
            this.lblApplicantNumber.Text = "APPLICANT ID";
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
            this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
            // 
            // btnAddSection
            // 
            this.btnAddSection.Location = new System.Drawing.Point(34, 139);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(134, 38);
            this.btnAddSection.TabIndex = 5;
            this.btnAddSection.Text = "ADD SECTION";
            this.btnAddSection.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
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
            this.groupBox1.ForeColor = System.Drawing.Color.Tomato;
            this.groupBox1.Location = new System.Drawing.Point(34, 210);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 206);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
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
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(149, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 147);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(149, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(414, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(211, 110);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(414, 20);
            this.textBox9.TabIndex = 13;
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
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.Color.Beige;
            this.txtHeading.Location = new System.Drawing.Point(12, 21);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(155, 20);
            this.txtHeading.TabIndex = 0;
            this.txtHeading.Text = "HEADING";
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(686, 446);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(134, 38);
            this.btnSaveTemplate.TabIndex = 7;
            this.btnSaveTemplate.Text = "SAVE TEMPLATE";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            // 
            // txtApplicationNumber
            // 
            this.txtApplicationNumber.Location = new System.Drawing.Point(207, 59);
            this.txtApplicationNumber.Name = "txtApplicationNumber";
            this.txtApplicationNumber.Size = new System.Drawing.Size(155, 20);
            this.txtApplicationNumber.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(896, 611);
            this.Controls.Add(this.txtApplicationNumber);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddSection);
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
    }
}

