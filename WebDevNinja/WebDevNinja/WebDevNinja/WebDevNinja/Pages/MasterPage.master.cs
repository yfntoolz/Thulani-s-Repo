using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["email"] == null)
        {
            Response.Redirect("../Login.aspx");
        }
    }
    protected void btnLogoutAdvisor_Click(object sender, EventArgs e)
    {
        Session.Clear();
        
        Response.Redirect("../Login.aspx");
    }
}
