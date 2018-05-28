using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        var emailExists = false;
        var connection = new Connection();

        emailExists = connection.CheckSalespersonEmail(txtEmail.Text);

        if (!emailExists)
        {
            if (txtFirstName.Text.Contains("~`!@#$%^&*()-+=|\\}]{[:;/'?/>.<\",") || txtFirstName.Text.Length > 13 || txtFirstName.Text.Contains(" "))
            {
                lblFirstNameErr.Visible = true;
            }
            else
            {
                if (txtLastName.Text.Contains(" ") || txtLastName.Text.Contains("0123456789") || txtLastName.Text.Contains("~`!@#$%^&*()_-+=|\\}]{[:;/'?/>.<\",") || txtLastName.Text.Length > 13 || txtLastName.Text.Contains(" "))
                {
                    lblLastNameErr.Visible = true;
                }
                else
                {
                    if (txtEmail.Text.Contains(" "))
                    {
                        lblEmailErr.Visible = true;
                    }
                    else
                    {
                        if (txtPassword.Text.Contains(" ") || txtPassword.Text.Length < 5)
                        {
                            lblPasswordErr.Visible = true;
                        }
                        else
                        {
                            var salesperson = new User(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPassword.Text);

                            connection.RegisterSalesperson(salesperson);

                            lblRegSuccessful.Visible = true;
                            lblFirstNameErr.Visible = false;
                            lblLastNameErr.Visible = false;
                            lblEmailErr.Visible = false;
                            lblPasswordErr.Visible = false;
                            txtFirstName.Text = "";
                            txtLastName.Text = "";
                            txtEmail.Text = "";
                            txtPassword.Text = "";
                            txtConfirmPassword.Text = "";

                            Response.Redirect("Pages/SalesMeetingForm.aspx");
                        }
                    }
                }
            }
        }
        else
        {
            lblExistsErr.Visible = true;
        }
    }
}