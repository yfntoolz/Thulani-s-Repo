using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_WordageForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        lblSentence.Visible = true;

        var sentence = "I'm going to teach " + txtTeach.Text + " how to " + txtResult.Text;
        var sentence2 = "I'm going to teach " + txtTeach.Text + " how to " + txtResult.Text + " and " + txtMoreResult.Text;
        var sentence3 = "I'm going to teach " + txtTeach.Text + " how to " + txtResult.Text + " in " + txtTimeFrame.Text;
        var sentence4 = "I'm going to teach " + txtTeach.Text + " how to " + txtResult.Text + " in " + txtTimeFrame.Text + " without " + txtFearOne.Text;
        var sentence5 = "I'm going to teach " + txtTeach.Text + " how to " + txtResult.Text + " in " + txtTimeFrame.Text + " without " + txtFearOne.Text + " or " + txtFearTwo.Text;

        lblSentence.Text = string.Format(@"<left>
        <h2>Headlines</h2>
        <ol>
            <li align='left'>{0}</li>
            <li align='left'>{1}</li>
            <li align='left'>{2}</li>
            <li align='left'>{3}</li>
            <li align='left'>{4}</li>
        </ol>", sentence, sentence2, sentence3, sentence4, sentence5);
    }
}