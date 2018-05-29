using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_SalesMeetingForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        var connection = new Connection();
        var result = "";
        var graph = "";
        var random = new Random();

        lblResult.Visible = true;

        if ((ddlMeetingType.SelectedIndex == 1 || ddlMeetingType.SelectedIndex == 2)
            && (ddlRole.SelectedIndex == 1 || ddlRole.SelectedIndex == 2 || ddlRole.SelectedIndex == 3)
            && (ddlAction.SelectedIndex == 1 || ddlAction.SelectedIndex == 3)
            && (ddlExamples.SelectedIndex == 2)
            && (ddlDecision.SelectedIndex == 2))
        {
            result = connection.GetRelevantResults(1);
            graph = connection.GetGraph(1);

        }
        else if ((ddlMeetingType.SelectedIndex == 1 || ddlMeetingType.SelectedIndex == 2)
                && (ddlRole.SelectedIndex == 1 || ddlRole.SelectedIndex == 2)
                && (ddlAction.SelectedIndex == 1 || ddlAction.SelectedIndex == 3)
                && (ddlExamples.SelectedIndex == 2)
                && (ddlDecision.SelectedIndex == 2))
        {
            result = connection.GetRelevantResults(2);
            graph = connection.GetGraph(2);
        }
        else if ((ddlMeetingType.SelectedIndex == 2)
                && (ddlRole.SelectedIndex == 2 || ddlRole.SelectedIndex == 3)
                && (ddlAction.SelectedIndex == 2)
                && (ddlExamples.SelectedIndex == 2)
                && (ddlDecision.SelectedIndex == 2))
        {
            result = connection.GetRelevantResults(3);
            graph = connection.GetGraph(3);
        }
        else if ((ddlMeetingType.SelectedIndex == 1 || ddlMeetingType.SelectedIndex == 2 || ddlMeetingType.SelectedIndex == 3)
                && (ddlRole.SelectedIndex == 1 || ddlRole.SelectedIndex == 2 || ddlRole.SelectedIndex == 3)
                && (ddlAction.SelectedIndex == 1 || ddlAction.SelectedIndex == 2 || ddlAction.SelectedIndex == 3)
                && (ddlExamples.SelectedIndex == 1)
                && (ddlDecision.SelectedIndex == 1))
        {
            result = connection.GetRelevantResults(4);
        }
        else if ((ddlMeetingType.SelectedIndex == 1 || ddlMeetingType.SelectedIndex == 2 || ddlMeetingType.SelectedIndex == 3)
                && (ddlRole.SelectedIndex == 1 || ddlRole.SelectedIndex == 2 || ddlRole.SelectedIndex == 3)
                && (ddlAction.SelectedIndex == 1 || ddlAction.SelectedIndex == 2 || ddlAction.SelectedIndex == 3)
                && (ddlExamples.SelectedIndex == 1)
                && (ddlDecision.SelectedIndex == 1))
        {
            result = connection.GetRelevantResults(5);
        }
        else
        {
            var randomNumber = random.Next(1, 5);

            result = connection.GetRelevantResults(randomNumber);
            
        }

        lblResult.Text = string.Format(@"<left>
        <h2>Suggestions</h2>
        <p>{0}</p> <br>
        <img src='../{1}' alt='No Graph Available'>", result, graph);

        //lblGraph.Text = @"<img src='../" + graph + @"' height='28' width='29' alt='" + Session["firstName"].ToString() + @"' />";
    }
}