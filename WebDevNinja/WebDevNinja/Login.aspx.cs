using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        var connection = new Connection();
        var salesperson = connection.SalespersonLogin(txtEmail.Text, txtPassword.Text);

        if (salesperson != null)
        {
            Session["email"] = salesperson.Email;
            Session["firstName"] = salesperson.FirstName;
            Session["lastName"] = salesperson.LastName;

            Response.Redirect("Pages/SalesMeetingForm.aspx");
        }
        else
        {
            lblError.Visible = true;
        }
    }
}