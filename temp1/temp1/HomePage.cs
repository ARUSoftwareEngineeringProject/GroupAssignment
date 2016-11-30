using System;
using System.Windows.Forms;

/// <summary>
/// Options for Template required
/// </summary>
namespace temp1
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        //To open the Template Options form
        private void btnCreateTemplate_Click(object sender, EventArgs e)
        {
            this.Hide();
            TemplateOptions tt = new TemplateOptions();
            tt.Show();
        }

        //To open the feedback form
        private void btnFeedbackForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feedback ff = new Feedback();
            ff.Show();
        }

        //https://msdn.microsoft.com/en-us/library/ms157894(v=vs.110).aspx
        //To exit the whole application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
