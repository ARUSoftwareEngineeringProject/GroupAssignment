namespace temp1
{
    partial class TemplateOptions
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
            this.btnEditDelete = new System.Windows.Forms.Button();
            this.btnNewTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEditDelete
            // 
            this.btnEditDelete.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnEditDelete.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDelete.Location = new System.Drawing.Point(229, 113);
            this.btnEditDelete.Name = "btnEditDelete";
            this.btnEditDelete.Size = new System.Drawing.Size(174, 64);
            this.btnEditDelete.TabIndex = 0;
            this.btnEditDelete.Text = "Edit / Delete template ";
            this.btnEditDelete.UseVisualStyleBackColor = false;
            this.btnEditDelete.Click += new System.EventHandler(this.btnEditDelete_Click);
            // 
            // btnNewTemplate
            // 
            this.btnNewTemplate.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnNewTemplate.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTemplate.Location = new System.Drawing.Point(37, 113);
            this.btnNewTemplate.Name = "btnNewTemplate";
            this.btnNewTemplate.Size = new System.Drawing.Size(146, 64);
            this.btnNewTemplate.TabIndex = 1;
            this.btnNewTemplate.Text = "New Template";
            this.btnNewTemplate.UseVisualStyleBackColor = false;
            this.btnNewTemplate.Click += new System.EventHandler(this.btnNewTemplate_Click);
            // 
            // TemplateOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(440, 299);
            this.Controls.Add(this.btnNewTemplate);
            this.Controls.Add(this.btnEditDelete);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TemplateOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TemplateOptions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEditDelete;
        private System.Windows.Forms.Button btnNewTemplate;
    }
}