<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true"
    CodeFile="SalesMeetingForm.aspx.cs" Inherits="Pages_SalesMeetingForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div>
        <h1>
            Sales Meeting Form
        </h1>
        (Scroll down after submitting to view results)
        <br />
        <br />
        <table align="center">
            <tr>
                <td>
                    <label>
                        Type of meeting</label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlMeetingType" runat="server" Height="30px" Width="600px">
                        <asp:ListItem>Select Value</asp:ListItem>
                        <asp:ListItem>Demonstration</asp:ListItem>
                        <asp:ListItem>Pitch</asp:ListItem>
                        <asp:ListItem>Meet and greet</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Role of person you're meeting</label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlRole" runat="server" Height="30px" Width="600px">
                        <asp:ListItem>Select Value</asp:ListItem>
                        <asp:ListItem>Sales Manager</asp:ListItem>
                        <asp:ListItem>Procurement</asp:ListItem>
                        <asp:ListItem>Human Resources</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Desired Action</label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlAction" runat="server" Height="30px" Width="600px">
                        <asp:ListItem>Select Value</asp:ListItem>
                        <asp:ListItem>Make a buying decision</asp:ListItem>
                        <asp:ListItem>Have them accept certain extra terms and conditions on a contract</asp:ListItem>
                        <asp:ListItem>Agree to donate to a charitable cause</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Do you have examples of others who have done the desired action and experienced
                        benefit?</label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlExamples" runat="server" Height="30px" Width="600px">
                        <asp:ListItem>Select Value</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Is there any urgency for them to make a decision, such as limited stock or time?</label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:DropDownList ID="ddlDecision" runat="server" Height="30px" Width="600px">
                        <asp:ListItem>Select Value</asp:ListItem>
                        <asp:ListItem>Yes</asp:ListItem>
                        <asp:ListItem>No</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td align="left">
                    <asp:Button ID="btnLogin" runat="server" Text="Submit" Height="30px" Width="100px"
                        OnClick="btnLogin_Click" />
                </td>
            </tr>
        </table>
        <div>
            <asp:Label ID="lblResult" runat="server" Text="Label" Visible="False"></asp:Label><br />
        </div>
    </div>
</asp:Content>
