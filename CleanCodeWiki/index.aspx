<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CleanCodeWiki.WebForm1" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div id="Div1" style="height: 115px">
            
            <div id="logininfo">
                <label id="userloggedin"></label><br />
                <label id="loginusername" for="username">User Name:</label>
                <input type="text" id="username" />         
                <label id="loginpassword" for="mypassword">Password:</label>
                <input type="password" id="mypassword" />
            </div>
            <div id="links">
                <a id="login" href="register.aspx">Log In</a>
                <a id="register" href="register.aspx">Register</a>
            </div>
    </div>

</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="test">
        <label id="lbTest">Welcome to Clean Code Wiki!!!!!</label>
    </div>

</asp:Content>


