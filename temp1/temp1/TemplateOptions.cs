using System;
using System.Windows.Forms;

namespace temp1
{
    public partial class TemplateOptions : Form
    {
        public TemplateOptions()
        {
            InitializeComponent();
        }

        private void btnNewTemplate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temp ff = new Temp();
            ff.Show();
        }

        private void btnEditDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectEditDelete ff = new SelectEditDelete();
            ff.Show();
        }
    }
}
