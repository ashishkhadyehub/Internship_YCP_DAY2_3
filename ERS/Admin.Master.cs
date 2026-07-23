using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ERS
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["Admin"] != null)
            {
                lilogin.Visible = false;
                lilogout.Visible = true;
                lilist.Visible = true;
            }
            else
            {
                lilogin.Visible = true;
                lilogout.Visible = false;
                lilist.Visible = false;
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("AdminLogin.aspx");
        }
    }
}