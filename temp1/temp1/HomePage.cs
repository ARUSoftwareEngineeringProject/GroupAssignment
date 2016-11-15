using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temp1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void btnCreateTemplate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temp tt = new Temp();
            tt.Show();
        }

        private void btnFeedbackForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback ff = new Feedback();
            ff.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
