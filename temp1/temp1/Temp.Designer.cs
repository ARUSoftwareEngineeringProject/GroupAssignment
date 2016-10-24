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
            this.components = new System.ComponentModel.Container();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.applicantIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfApplicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicantsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.happyTechDatabaseDataSet1 = new temp1.HappyTechDatabaseDataSet1();
            this.applicantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.happyTechDatabaseDataSet = new temp1.HappyTechDatabaseDataSet();
            this.applicantsTableAdapter = new temp1.HappyTechDatabaseDataSetTableAdapters.ApplicantsTableAdapter();
            this.applicantsTableAdapter1 = new temp1.HappyTechDatabaseDataSet1TableAdapters.ApplicantsTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPosition.Location = new System.Drawing.Point(60, 185);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 25);
            this.lblPosition.TabIndex = 1;
            this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
            // 
            // btnAddSection
            // 
            this.btnAddSection.Location = new System.Drawing.Point(51, 352);
            this.btnAddSection.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(112, 58);
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
            this.groupBox1.Location = new System.Drawing.Point(51, 420);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1179, 317);
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
            this.comboBox4.Location = new System.Drawing.Point(962, 225);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(94, 28);
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
            this.comboBox3.Location = new System.Drawing.Point(962, 168);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(94, 28);
            this.comboBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(18, 169);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(222, 26);
            this.textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(18, 226);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(222, 26);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 226);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(619, 26);
            this.textBox2.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(316, 169);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(619, 26);
            this.textBox9.TabIndex = 13;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
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
            this.cmbSectionOptions.Location = new System.Drawing.Point(864, 54);
            this.cmbSectionOptions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbSectionOptions.Name = "cmbSectionOptions";
            this.cmbSectionOptions.Size = new System.Drawing.Size(217, 28);
            this.cmbSectionOptions.TabIndex = 8;
            this.cmbSectionOptions.SelectedIndexChanged += new System.EventHandler(this.cmbSectionOptions_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1092, 54);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(18, 97);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 45);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.Color.Beige;
            this.txtHeading.Location = new System.Drawing.Point(18, 32);
            this.txtHeading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(230, 26);
            this.txtHeading.TabIndex = 0;
            this.txtHeading.Text = "HEADING";
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Location = new System.Drawing.Point(1029, 746);
            this.btnSaveTemplate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(201, 58);
            this.btnSaveTemplate.TabIndex = 7;
            this.btnSaveTemplate.Text = "SAVE TEMPLATE";
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.applicantIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.telephoneNoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.typeOfApplicationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.applicantsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(51, 185);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1146, 154);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_CellContentClick);
            // 
            // applicantIDDataGridViewTextBoxColumn
            // 
            this.applicantIDDataGridViewTextBoxColumn.DataPropertyName = "ApplicantID";
            this.applicantIDDataGridViewTextBoxColumn.HeaderText = "ApplicantID";
            this.applicantIDDataGridViewTextBoxColumn.Name = "applicantIDDataGridViewTextBoxColumn";
            this.applicantIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneNoDataGridViewTextBoxColumn
            // 
            this.telephoneNoDataGridViewTextBoxColumn.DataPropertyName = "telephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.HeaderText = "telephoneNo";
            this.telephoneNoDataGridViewTextBoxColumn.Name = "telephoneNoDataGridViewTextBoxColumn";
            this.telephoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeOfApplicationDataGridViewTextBoxColumn
            // 
            this.typeOfApplicationDataGridViewTextBoxColumn.DataPropertyName = "typeOfApplication";
            this.typeOfApplicationDataGridViewTextBoxColumn.HeaderText = "typeOfApplication";
            this.typeOfApplicationDataGridViewTextBoxColumn.Name = "typeOfApplicationDataGridViewTextBoxColumn";
            this.typeOfApplicationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // applicantsBindingSource1
            // 
            this.applicantsBindingSource1.DataMember = "Applicants";
            this.applicantsBindingSource1.DataSource = this.happyTechDatabaseDataSet1;
            // 
            // happyTechDatabaseDataSet1
            // 
            this.happyTechDatabaseDataSet1.DataSetName = "HappyTechDatabaseDataSet1";
            this.happyTechDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantsBindingSource
            // 
            this.applicantsBindingSource.DataMember = "Applicants";
            this.applicantsBindingSource.DataSource = this.happyTechDatabaseDataSet;
            // 
            // happyTechDatabaseDataSet
            // 
            this.happyTechDatabaseDataSet.DataSetName = "HappyTechDatabaseDataSet";
            this.happyTechDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // applicantsTableAdapter
            // 
            this.applicantsTableAdapter.ClearBeforeFill = true;
            // 
            // applicantsTableAdapter1
            // 
            this.applicantsTableAdapter1.ClearBeforeFill = true;
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1344, 940);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSaveTemplate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddSection);
            this.Controls.Add(this.lblPosition);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Temp";
            this.Text = "TEMPLATE";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.happyTechDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private HappyTechDatabaseDataSet happyTechDatabaseDataSet;
        private System.Windows.Forms.BindingSource applicantsBindingSource;
        private HappyTechDatabaseDataSetTableAdapters.ApplicantsTableAdapter applicantsTableAdapter;
        private HappyTechDatabaseDataSet1 happyTechDatabaseDataSet1;
        private System.Windows.Forms.BindingSource applicantsBindingSource1;
        private HappyTechDatabaseDataSet1TableAdapters.ApplicantsTableAdapter applicantsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicantIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfApplicationDataGridViewTextBoxColumn;
    }
}

