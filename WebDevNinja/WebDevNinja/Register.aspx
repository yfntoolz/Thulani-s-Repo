<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <h1>
        Salesperson Registration</h1>
    <table id="tableReg" align="center">
        <tr>
            <td align="left">
                First Name
            </td>
            <td align="left">
                <asp:TextBox ID="txtFirstName" runat="server" Height="30px" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                    ControlToValidate="txtFirstName"></asp:RequiredFieldValidator>
            </td>
            <td align="left">
                <asp:Label ID="lblFirstNameErr" runat="server" Text="Invalid value entered for first name"
                    ForeColor="#FF3300" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                Last Name
            </td>
            <td align="left">
                <asp:TextBox ID="txtLastName" runat="server" Height="30px" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                    ControlToValidate="txtLastName"></asp:RequiredFieldValidator>
            </td>
            <td align="left">
                <asp:Label ID="lblLastNameErr" runat="server" Text="Invalid value entered for last name"
                    ForeColor="#FF3300" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                Email
            </td>
            <td align="left">
                <asp:TextBox type="email" ID="txtEmail" runat="server" Height="30px" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*"
                    ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
            </td>
            <td align="left">
                <asp:Label ID="lblEmailErr" runat="server" Text="Value entered for email is invalid"
                    ForeColor="#FF3300" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                Password
            </td>
            <td align="left">
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Height="30px" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*"
                    ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
            </td>
            <td align="left">
                <asp:Label ID="lblPasswordErr" runat="server" Text="Password cannot be shorter than 5 characters"
                    ForeColor="#FF3300" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                Confirm Password
            </td>
            <td align="left">
                <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password" Height="30px" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*"
                    ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
            </td>
            <td align="left">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords do not match"
                    ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" 
                    ForeColor="#FF3300"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td align="left">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" Height="30px" Width="100px" />
            </td>
        </tr>
        <tr>
        <td></td>
        <td><a href="Login.aspx"><label>Login</label></a></td></tr>
    </table>
    <br />
    <asp:Label ID="lblRegSuccessful" runat="server" Text="Registered Successfully!" ForeColor="Blue"
        Visible="false"></asp:Label><br />
    <asp:Label ID="lblExistsErr" runat="server" Text="User is already registered!" ForeColor="#FF3300"
        Visible="False"></asp:Label>
</asp:Content>
