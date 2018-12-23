using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EFModelFirstApproach
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void btnGetData_Click(object sender, EventArgs e)
        {
            
            
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            //using (EFModelContainer efc = new EFModelContainer())
            //{
            //    Employee emp = new Employee
            //    {
            //        FirstName = "Ramesh",
            //        Gender = "M",
            //        LastName = "R",
            //        Salary = 30000,
            //    };

            //    efc.SaveChanges();
            //}
        }
    }
}