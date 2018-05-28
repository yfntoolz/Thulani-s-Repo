<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div style="height: 300px">
        <h1>
            Salesperson Login</h1>
        <br />
        <table align="center">
            <tr>
                <td align="left">
                    Email
                </td>
                <td>
                    <asp:TextBox ID="txtEmail" type="email" runat="server" Height="30px" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
                        ControlToValidate="txtEmail"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="left">
                    Password
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Height="30px" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
                        ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td align="left">
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="Button1_Click" Height="30px" Width="100px"/>
                </td>
            </tr>
            <td></td>
            <td><a href="Register.aspx"><label>Don't have an account?</label></a></td>
            </table>
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" Text="Incorrect Username or Password!"
            Visible="False"></asp:Label>
    </div>
</asp:Content>
