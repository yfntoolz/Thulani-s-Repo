<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/MasterPage.master" AutoEventWireup="true"
    CodeFile="WordageForm.aspx.cs" Inherits="Pages_WordageForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>
        Wordage Form</h1>
        (Scroll down after submitting to view results)
        <br />
        <br />
    <table id="tableReg" align="center">
        <tr>
            <td>
            </td>
            <td align="left">
                <label>
                    Who are you going to teach?</label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <asp:TextBox ID="txtTeach" runat="server" Height="30px" Width="600px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                    ControlToValidate="txtTeach"></asp:RequiredFieldValidator>
            </td>
            <td align="left">
                <asp:Label ID="lblFirstNameErr" runat="server" Text="Invalid value entered for first name"
                    ForeColor="#FF3300" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <label>
                    What is the #1 big, huge result they desire most in this area?</label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <asp:TextBox ID="txtResult" runat="server" Height="30px" Width="600px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                    ControlToValidate="txtResult"></asp:RequiredFieldValidator>
            </td>
            <td align="left">
                <asp:Label ID="lblLastNameErr" runat="server" Text="Invalid value entered for last name"
                    ForeColor="#FF3300" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <label>
                    What is one more big, huge result that they desire the most in this area?</label>
            </td>
        </tr>
        <tr>
            <td align="left">
            </td>
            <td align="left">
                <asp:TextBox ID="txtMoreResult" runat="server" Height="30px" Width="600px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*"
                    ControlToValidate="txtMoreResult"></asp:RequiredFieldValidator>
            </td>
            <td align="left">
                <asp:Label ID="lblEmailErr" runat="server" Text="Value entered for email is invalid"
                    ForeColor="#FF3300" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <label>
                    What's the #1 big thing that that they are most AFRAID of in this area?</label>
            </td>
        </tr>
        <tr>
            <td align="left">
            </td>
            <td align="left">
                <asp:TextBox ID="txtFearOne" runat="server" Height="30px" Width="600px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*"
                    ControlToValidate="txtFearOne"></asp:RequiredFieldValidator>
            </td>
            <td align="left">
                <asp:Label ID="lblPasswordErr" runat="server" Text="Password cannot be shorter than 5 characters"
                    ForeColor="#FF3300" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <label>
                    What's one more big thing they are most AFRAID of in this area?</label>
            </td>
        </tr>
        <tr>
            <td align="left">
            </td>
            <td align="left">
                <asp:TextBox ID="txtFearTwo" runat="server" Height="30px" Width="600px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*"
                    ControlToValidate="txtFearTwo"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <label>
                    What time frame can you help them get results?</label>
            </td>
        </tr>
        <tr>
            <td align="left">
            </td>
            <td align="left">
                <asp:TextBox ID="txtTimeFrame" runat="server" Height="30px" Width="600px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
                    ControlToValidate="txtTimeFrame"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <asp:Button ID="btnRegister" runat="server" Text="Submit" Height="30px" 
                    Width="100px" onclick="btnRegister_Click" />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
    <div>
        <asp:Label ID="lblSentence" runat="server" Text="Label" Visible="False"></asp:Label>
    </div>
</asp:Content>
