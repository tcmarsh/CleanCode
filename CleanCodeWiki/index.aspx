<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CleanCodeWiki.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div id="Div1" style="height: 115px">
            
            <div id="logininfo" runat="server">
                <asp:Label id="userloggedin" runat="server" Visible="False"></asp:Label><br />
                <label id="loginusername" runat="server" for="username">User Name:</label>
                <input type="text" id="username" runat="server"/>         
                <label id="loginpassword" runat="server" for="mypassword">Password:</label>
                <input type="password" runat="server" id="mypassword" />
            </div>
            <div id="links" runat="server">
                <asp:LinkButton id="login" runat="server">Log In</asp:LinkButton>
                <asp:LinkButton id="register" runat="server">Register</asp:LinkButton>
            </div>
    </div>

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="test" runat="server">
        <label id="lbTest" runat="server">Welcome to Clean Code Wiki!!!!!</label>
    </div>

</asp:Content>


