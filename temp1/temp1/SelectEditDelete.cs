using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace temp1
{
    public partial class SelectEditDelete : Form
    {
        public SelectEditDelete()
        {
            InitializeComponent();
        }
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Najat\Desktop\SEAssignment\GroupAssignment7\temp1\temp1\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        private void lblTemplateName_Click(object sender, EventArgs e)
        {

        }

        private void cmbTempID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //opening the connection to the database
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Template where TemplateID = '" + cmbTempID.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //filling the text boxes
            foreach (DataRow dr in dt.Rows)
            {
                txtTemplateName.Text = dr["TemplateName"].ToString();
                txtPosition.Text = dr["Position"].ToString();
                txtHeading.Text = dr["Heading"].ToString();
                txtSubHeading.Text = dr["SubHeading"].ToString();
                txtComment.Text = dr["Comment"].ToString();
                // txtSubHeading2.Text = dr[""].ToString();
                // txtComment2.Text = dr["Contact"].ToString();
            }
            //closing the connection to the database
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //To update template column
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            //opening the connection to the database
            con.Open();
            //updating data to database
            command.CommandText = "update Template set TemplateName='" + txtTemplateName.Text + "', Heading= '" + txtHeading.Text + "', SubHeading= '" + txtSubHeading.Text + "', Comment= '" + txtComment.Text + "', Position= '" + txtPosition.Text + "' where TemplateID= '" + cmbTempID.SelectedItem.ToString() +"'";
            command.ExecuteNonQuery();
            //closing the connection to the database
            con.Close();
            //confirming data is updated
            MessageBox.Show("Datas Updated");
        }

        private void SelectEditDelete_Load(object sender, EventArgs e)
        {

            //opening the connection to the database
            con.Open();
            //adding all staff ID 
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Template";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            // fillin template information into the text boxes
            foreach (DataRow dr in dt.Rows)
            {
                cmbTempID.Items.Add(dr["TemplateID"].ToString());
            }
            //closing the connection to the database
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //To delete template column
            SqlCommand command = new SqlCommand();
            command.Connection = con;
            command.CommandType = CommandType.Text;
            //opening the connection to the database
            con.Open();
            //deleting data to database
            command.CommandText = "delete from Template where TemplateID = '" + cmbTempID.SelectedItem.ToString() + "'";
            command.ExecuteNonQuery();
            //closing the connection to the database
            con.Close();
            //confirming data is deleted
            MessageBox.Show("Datas Deleted");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
