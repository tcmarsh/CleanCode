<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="CleanCodeWiki.WebForm2" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div id="Div1" style="height: 90px">
            <br />
            <div id="links">
                <a id="backtohome" href="index.aspx">Go Back to Home</a>
            </div>
    </div>

</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="registerWelcome">
        <label id="lbregister">Welcome to Clean Code Wiki Registration</label>
    </div><br />
    <div id="registerinfo">
        <label id="lbregUserName" for="regUserName">Username (E-mail Address):</label>
        <input type="text" id="regUserName" /><br />
        <label id="lbregLastName" for="regLastName" >Last Name:</label>
        <input type="text" id="regLastName" /><br />
        <label id="lbregPassword" for="regPassword" >Password:</label>
        <input type="password" id="regPassword" /><br />
        <label id="lbconfirmPassword" for="regConfirmPassword" >Confirm Password:</label>
        <input type="password" id="regConfirmPassword" />
        <br /><br />
        <button type="button" id="submitregistration" >Register</button>
    </div>
</asp:Content>
