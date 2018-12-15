using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASPDotNetCRUDApplication
{
    public partial class Default : System.Web.UI.Page
    {
        SqlConnection sqlcon = new SqlConnection("Data Source=WIN-BD9GNJAO2CS;Initial Catalog=Class;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string insert = "insert into Employee values ('" +txtName.Text+ "','" +txtAddress.Text+ "','" +txtEmail.Text+ "')";
            SqlCommand cmd = new SqlCommand(insert,sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            lblMsg.Text = "Data Inserted Successfully!";
            txtName.Text = txtEmail.Text = txtAddress.Text = null;

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            string update = "update Employee set FirstName='" + txtName.Text + "', Address='" + txtAddress.Text + "', Email= '" + txtEmail.Text + "' where FirstName='" + txtName.Text + "'";
            SqlCommand cmd = new SqlCommand(update, sqlcon);
            cmd.ExecuteNonQuery();
            sqlcon.Close();
            lblMsg.Text = "Data Updated Successfully!";
            txtName.Text = txtEmail.Text = txtAddress.Text = null;
        }
    }
}