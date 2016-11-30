using System;
using System.Windows.Forms;
/// <summary>
/// Options for creating a new Template or editing an existing template
/// </summary>
namespace temp1
{
    //initialising
    public partial class TemplateOptions : Form
    {
        public TemplateOptions()
        {
            InitializeComponent();
        }
        //To open the new tamplate form
        private void btnNewTemplate_Click(object sender, EventArgs e)
        {
            this.Hide();
            Temp ff = new Temp();
            ff.Show();
        }
        //to open the edit/delete form
        private void btnEditDelete_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectEditDelete ff = new SelectEditDelete();
            ff.Show();
        }
    }
}
