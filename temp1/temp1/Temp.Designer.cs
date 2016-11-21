using System.Windows.Forms;

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
            this.btn_SaveTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.txtStaffContact = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtFeedback = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbStaffID = new System.Windows.Forms.ComboBox();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.lblTemplateName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
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
            this.btnAddSection.Location = new System.Drawing.Point(23, 31);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(75, 23);
            this.btnAddSection.TabIndex = 45;
            this.btnAddSection.Text = "Add Section";
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
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
            this.txtStaffContact.Location = new System.Drawing.Point(400, 133);
            this.txtStaffContact.Name = "txtStaffContact";
            this.txtStaffContact.ReadOnly = true;
            this.txtStaffContact.Size = new System.Drawing.Size(163, 20);
            this.txtStaffContact.TabIndex = 31;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(400, 81);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(163, 20);
            this.txtStaffName.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(267, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "STAFF CONTACT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "STAFF NAME";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(400, 37);
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
            this.txtFeedback.Text = "HOME PAGE";
            this.txtFeedback.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 40);
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
            // txtTemplateName
            // 
            this.txtTemplateName.Location = new System.Drawing.Point(12, 130);
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Size = new System.Drawing.Size(163, 20);
            this.txtTemplateName.TabIndex = 41;
            // 
            // lblTemplateName
            // 
            this.lblTemplateName.AutoSize = true;
            this.lblTemplateName.Location = new System.Drawing.Point(9, 107);
            this.lblTemplateName.Name = "lblTemplateName";
            this.lblTemplateName.Size = new System.Drawing.Size(182, 13);
            this.lblTemplateName.TabIndex = 42;
            this.lblTemplateName.Text = "PLEASE ENTER TEMPLATE NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "PLEASE ENTER THE POSITON";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(400, 205);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(163, 20);
            this.txtPosition.TabIndex = 44;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.btnAddSection);
            this.groupBox1.Location = new System.Drawing.Point(111, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(931, 358);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 78);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(919, 253);
            this.flowLayoutPanel1.TabIndex = 46;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1224, 681);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTemplateName);
            this.Controls.Add(this.txtTemplateName);
            this.Controls.Add(this.cmbStaffID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtStaffContact);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_SaveTemplate);
            this.Controls.Add(this.lblPosition);
            this.Name = "Temp";
            this.Text = "TEMPLATE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Button btn_SaveTemplate;
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbStaffID;
        protected System.Windows.Forms.TextBox txtStaffContact;
        protected System.Windows.Forms.TextBox txtStaffName;
        protected System.Windows.Forms.TextBox txtStaffID;
        protected System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.Label lblTemplateName;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.GroupBox groupBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

