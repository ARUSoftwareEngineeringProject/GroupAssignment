namespace temp1
{
    partial class HomePage
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
            this.btnCreateTemplate = new System.Windows.Forms.Button();
            this.btnFeedbackForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateTemplate
            // 
            this.btnCreateTemplate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreateTemplate.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTemplate.Location = new System.Drawing.Point(12, 75);
            this.btnCreateTemplate.Name = "btnCreateTemplate";
            this.btnCreateTemplate.Size = new System.Drawing.Size(210, 93);
            this.btnCreateTemplate.TabIndex = 0;
            this.btnCreateTemplate.Text = "TEMPLATE  FORM";
            this.btnCreateTemplate.UseVisualStyleBackColor = false;
            this.btnCreateTemplate.Click += new System.EventHandler(this.btnCreateTemplate_Click);
            // 
            // btnFeedbackForm
            // 
            this.btnFeedbackForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnFeedbackForm.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFeedbackForm.Location = new System.Drawing.Point(241, 77);
            this.btnFeedbackForm.Name = "btnFeedbackForm";
            this.btnFeedbackForm.Size = new System.Drawing.Size(194, 91);
            this.btnFeedbackForm.TabIndex = 1;
            this.btnFeedbackForm.Text = "FEEDBACK FORM";
            this.btnFeedbackForm.UseVisualStyleBackColor = false;
            this.btnFeedbackForm.Click += new System.EventHandler(this.btnFeedbackForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(454, 77);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 91);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 293);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFeedbackForm);
            this.Controls.Add(this.btnCreateTemplate);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateTemplate;
        private System.Windows.Forms.Button btnFeedbackForm;
        private System.Windows.Forms.Button btnExit;
    }
}