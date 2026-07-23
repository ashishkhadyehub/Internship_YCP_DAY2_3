using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERS
{
    public partial class EmployeeList : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            gvEmployees.DataSource = getEmpList();
            gvEmployees.DataBind();
        }

        DataSet getEmpList()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select Srno as Employee_Id,Name,Contact,Email,Department,SubmitDate as Registered_Date from EmpRegister order by Srno desc",con);
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds;
        }
    }
}