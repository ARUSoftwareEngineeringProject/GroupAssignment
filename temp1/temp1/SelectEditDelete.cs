using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace temp1
{
    public partial class SelectEditDelete : Form
    {
        public SelectEditDelete()
        {
            InitializeComponent();
        }
       
        private void lblTemplateName_Click(object sender, EventArgs e)
        {

        }

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //fill in the grid 
            DataSet dsPerson = DatabaseConnection.getDBConnectionInstance().getDataSet("delete from Template where TemplateID = '" + cmbTempID.SelectedItem.ToString() + "'");

            //confirming data is deleted
            MessageBox.Show("Datas Deleted");

            txtTemplateName.Clear();
            txtPosition.Clear();
            txtHeading.Clear();
            txtSubHeading.Clear();
            txtComment.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
