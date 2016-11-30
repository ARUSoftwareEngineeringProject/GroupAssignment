namespace temp1
{
    partial class SelectEditDelete
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
            this.cmbTempID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemplateName = new System.Windows.Forms.TextBox();
            this.txtSubHeading = new System.Windows.Forms.TextBox();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.lblTemplateName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbTempID
            // 
            this.cmbTempID.FormattingEnabled = true;
            this.cmbTempID.Location = new System.Drawing.Point(203, 36);
            this.cmbTempID.Name = "cmbTempID";
            this.cmbTempID.Size = new System.Drawing.Size(121, 21);
            this.cmbTempID.TabIndex = 0;
            this.cmbTempID.SelectedIndexChanged += new System.EventHandler(this.cmbTempID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SELECT TEMPLATE ID";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(247, 223);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(414, 20);
            this.txtComment.TabIndex = 46;
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(545, 105);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(163, 20);
            this.txtPosition.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = " THE POSITON";
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.Location = new System.Drawing.Point(203, 105);
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Size = new System.Drawing.Size(163, 20);
            this.txtTemplateName.TabIndex = 48;
            // 
            // txtSubHeading
            // 
            this.txtSubHeading.Location = new System.Drawing.Point(32, 223);
            this.txtSubHeading.Name = "txtSubHeading";
            this.txtSubHeading.Size = new System.Drawing.Size(149, 20);
            this.txtSubHeading.TabIndex = 47;
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.Color.Beige;
            this.txtHeading.Location = new System.Drawing.Point(32, 177);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(155, 20);
            this.txtHeading.TabIndex = 45;
            this.txtHeading.Text = "HEADING";
            // 
            // lblTemplateName
            // 
            this.lblTemplateName.AutoSize = true;
            this.lblTemplateName.Location = new System.Drawing.Point(29, 105);
            this.lblTemplateName.Name = "lblTemplateName";
            this.lblTemplateName.Size = new System.Drawing.Size(101, 13);
            this.lblTemplateName.TabIndex = 49;
            this.lblTemplateName.Text = " TEMPLATE NAME";
            //this.lblTemplateName.Click += new System.EventHandler(this.lblTemplateName_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(457, 275);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 43);
            this.btnUpdate.TabIndex = 54;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(586, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 43);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(691, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(38, 35);
            this.btnExit.TabIndex = 65;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SelectEditDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(751, 351);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTemplateName);
            this.Controls.Add(this.txtSubHeading);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.lblTemplateName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbTempID);
            this.Name = "SelectEditDelete";
            this.Text = "SelectEditDelete";
            this.Load += new System.EventHandler(this.SelectEditDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTempID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComment;
        protected System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox txtTemplateName;
        private System.Windows.Forms.TextBox txtSubHeading;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.Label lblTemplateName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
    }
}