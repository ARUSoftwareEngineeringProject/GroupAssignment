using System;
using System.Data;
using System.Windows.Forms;

/// <summary>
/// form for editing and deleting any values from the database - Template form
/// </summary>
namespace temp1
{
    public partial class SelectEditDelete : Form
    {
        public SelectEditDelete()
        {
            InitializeComponent();
        }
        /// <summary>
        /// https://www.youtube.com/watch?v=tm4GHnHw2wc&index=13&list=PLGtk9G6Hf1aEHV-IrHi7g0O5tcRSL__6a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTempID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("select * from Template where TemplateID = '" + cmbTempID.SelectedItem.ToString() + "'");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            //set up the data grid view
            foreach (DataRow dr in dsPerson.Tables[0].Rows)
            {
                txtTemplateName.Text = dr["TemplateName"].ToString();
                txtPosition.Text = dr["Position"].ToString();
                txtHeading.Text = dr["Heading"].ToString();
                txtSubHeading.Text = dr["SubHeading"].ToString();
                txtComment.Text = dr["Comment"].ToString();
                
            }
           
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("update Template set TemplateName='" + txtTemplateName.Text + "', Heading= '" + txtHeading.Text + "', SubHeading= '" + txtSubHeading.Text + "', Comment= '" + txtComment.Text + "', Position= '" + txtPosition.Text + "' where TemplateID= '" + cmbTempID.SelectedItem.ToString() + "'");

            //confirming data is updated
            MessageBox.Show("Datas Updated");

            //clearing the textboxes ready for new function
            txtTemplateName.Clear();
            txtPosition.Clear();
            txtHeading.Clear();
            txtSubHeading.Clear();
            txtComment.Clear();
            

        }

        private void SelectEditDelete_Load(object sender, EventArgs e)
        {

            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("select * from Template");


            //get the table from the dataset
            DataTable dtPerson = dsPerson.Tables[0];

            foreach (DataRow dr in dsPerson.Tables[0].Rows)
            {
                cmbTempID.Items.Add(dr["TemplateID"].ToString());
            }
        }
        //https://www.youtube.com/watch?v=GysB6QEc04Y
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("delete from Template where TemplateID = '" + cmbTempID.SelectedItem.ToString() + "'");

            //confirming data is deleted
            MessageBox.Show("Datas Deleted");

            //clearing the textboxes ready for new function
            txtTemplateName.Clear();
            txtTemplateName.Clear();
            txtPosition.Clear();
            txtHeading.Clear();
            txtSubHeading.Clear();
            txtComment.Clear();

        }
        // exit the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage ff = new HomePage();
            ff.Show();
        }
    }
}
