namespace temp1
{
    partial class Feedback
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
            this.components = new System.ComponentModel.Container();
            this.happyTechDatabaseDataSet3 = new temp1.HappyTechDatabaseDataSet3();
            this.applicantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.applicantsTableAdapter = new temp1.HappyTechDatabaseDataSet3TableAdapters.ApplicantsTableAdapter();
            this.typeOfApplicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgApplicant = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.txtTypeOfApplication = new System.Windows.Forms.TextBox();
            this.txtTelephoneNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtApplicantID = new System.Windows.Forms.TextBox();
            this.lblSelection = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgApplicant)).BeginInit();
            this.SuspendLayout();
            // 
            // happyTechDatabaseDataSet3
            // 
            this.happyTechDatabaseDataSet3.DataSetName = "HappyTechDatabaseDataSet3";
            this.happyTechDatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantsBindingSource
            // 
            this.applicantsBindingSource.DataMember = "Applicants";
            this.applicantsBindingSource.DataSource = this.happyTechDatabaseDataSet3;
            // 
            // applicantsTableAdapter
            // 
            this.applicantsTableAdapter.ClearBeforeFill = true;
            // 
            // typeOfApplicationDataGridViewTextBoxColumn
            // 
            this.typeOfApplicationDataGridViewTextBoxColumn.DataPropertyName = "typeOfApplication";
            this.typeOfApplicationDataGridViewTextBoxColumn.HeaderText = "typeOfApplication";
            this.typeOfApplicationDataGridViewTextBoxColumn.Name = "typeOfApplicationDataGridViewTextBoxColumn";
            this.typeOfApplicationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneNoDataGridViewTextBoxColumn
            // 
            this.telephoneNoDataGridViewTextBoxColumn.DataPropertyName = "telephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.HeaderText = "telephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.Name = "telephoneNoDataGridViewTextBoxColumn";
            this.telephoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applicantIDDataGridViewTextBoxColumn
            // 
            this.applicantIDDataGridViewTextBoxColumn.DataPropertyName = "ApplicantID";
            this.applicantIDDataGridViewTextBoxColumn.HeaderText = "ApplicantID";
            this.applicantIDDataGridViewTextBoxColumn.Name = "applicantIDDataGridViewTextBoxColumn";
            this.applicantIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dtgApplicant
            // 
            this.dtgApplicant.AllowUserToAddRows = false;
            this.dtgApplicant.AllowUserToDeleteRows = false;
            this.dtgApplicant.AutoGenerateColumns = false;
            this.dtgApplicant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgApplicant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applicantIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.typeOfApplicationDataGridViewTextBoxColumn});
            this.dtgApplicant.DataSource = this.applicantsBindingSource;
            this.dtgApplicant.Location = new System.Drawing.Point(22, 67);
            this.dtgApplicant.Name = "dtgApplicant";
            this.dtgApplicant.ReadOnly = true;
            this.dtgApplicant.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgApplicant.Size = new System.Drawing.Size(149, 103);
            this.dtgApplicant.TabIndex = 10;
            this.dtgApplicant.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dtgApplicant_MouseDoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(551, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "TELEPHONE NO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "EMAIL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(551, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "DATE OF BIRTH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "TYPE OF APPLICATION";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "FULL NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "ADDRESS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "APPLICANT ID";
            // 
            // txtDOB
            // 
            this.txtDOB.Location = new System.Drawing.Point(647, 137);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(163, 20);
            this.txtDOB.TabIndex = 37;
            // 
            // txtTypeOfApplication
            // 
            this.txtTypeOfApplication.Location = new System.Drawing.Point(647, 176);
            this.txtTypeOfApplication.Name = "txtTypeOfApplication";
            this.txtTypeOfApplication.ReadOnly = true;
            this.txtTypeOfApplication.Size = new System.Drawing.Size(163, 20);
            this.txtTypeOfApplication.TabIndex = 36;
            // 
            // txtTelephoneNo
            // 
            this.txtTelephoneNo.Location = new System.Drawing.Point(647, 62);
            this.txtTelephoneNo.Name = "txtTelephoneNo";
            this.txtTelephoneNo.ReadOnly = true;
            this.txtTelephoneNo.Size = new System.Drawing.Size(163, 20);
            this.txtTelephoneNo.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(323, 99);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 34;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(647, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(163, 20);
            this.txtEmail.TabIndex = 33;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(323, 137);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(163, 20);
            this.txtAddress.TabIndex = 32;
            // 
            // txtApplicantID
            // 
            this.txtApplicantID.Location = new System.Drawing.Point(323, 62);
            this.txtApplicantID.Name = "txtApplicantID";
            this.txtApplicantID.ReadOnly = true;
            this.txtApplicantID.Size = new System.Drawing.Size(163, 20);
            this.txtApplicantID.TabIndex = 31;
            // 
            // lblSelection
            // 
            this.lblSelection.AutoSize = true;
            this.lblSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSelection.Location = new System.Drawing.Point(12, 25);
            this.lblSelection.Name = "lblSelection";
            this.lblSelection.Size = new System.Drawing.Size(199, 20);
            this.lblSelection.TabIndex = 45;
            this.lblSelection.Text = "Please Select Applicant";
            // 
            // Feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(944, 480);
            this.Controls.Add(this.lblSelection);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtTypeOfApplication);
            this.Controls.Add(this.txtTelephoneNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtApplicantID);
            this.Controls.Add(this.dtgApplicant);
            this.Name = "Feedback";
            this.Text = "Feedback";
            this.Load += new System.EventHandler(this.Feedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgApplicant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HappyTechDatabaseDataSet3 happyTechDatabaseDataSet3;
        private System.Windows.Forms.BindingSource applicantsBindingSource;
        private HappyTechDatabaseDataSet3TableAdapters.ApplicantsTableAdapter applicantsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfApplicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dtgApplicant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.TextBox txtTypeOfApplication;
        private System.Windows.Forms.TextBox txtTelephoneNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtApplicantID;
        private System.Windows.Forms.Label lblSelection;
    }
}