using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERS
{
    public partial class Profile : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connstr"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["EmployeeId"]!=null)
            {
                getProfile();
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
        }

        void getProfile()
        {
            con.Close();
            SqlCommand cmd = new SqlCommand("select * from EmpRegister where Srno=@empid", con);
            cmd.Parameters.AddWithValue("@empid", Session["EmployeeId"]);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                txtName.Text = sdr.GetValue(1).ToString();
                txtContact.Text= sdr.GetValue(2).ToString();
                txtEmail.Text= sdr.GetValue(3).ToString();
                txtdept.Text= sdr.GetValue(4).ToString();
            }
        
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}