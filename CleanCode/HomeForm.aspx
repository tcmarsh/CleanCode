<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeForm.aspx.cs" Inherits="CleanCode.HomeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Clean Code Knowledge Base</title>

	<link rel="stylesheet" type="text/css" href="app_stylesheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <h1>Clean Code Knowledge Base</h1>
	<hr />
	<div class="left_navigation">
		<ul>
			<li><a href="">Browse C2KB</a></li>
			<li><a href="">Search Articles</a></li>
			<li><a href="">Register</a></li>
		</ul>
		<ul>
			<li><a href="">Recent Articles</a></li>
			<li><a href="">Popular Articles</a></li>
		</ul>
		<input type="text" placeholder="Enter search term" />
		<input type="button" value="Search" />
	</div>
    <div class="contents">
		<p>
			Welcome to the C2KB! We are a repository of information 
			related to writing clean, testable code. Any input is welcome, but
			be warned - contributions are peer reviewed, and if you have soft
			skin, you may be bleeding from some remarks!
		</p>
		<p>
			That being said, if you'd like to contribute, please sign up! If
			not, you can still sign up to contribute to metrics for what
			articles are being viewed the most, or even just to make comments
			about the articles you read! Your level of involvement is up to
			you, but we hope you'll join us in our quest for better development
			practices.
		</p>
    </div>
	<hr />
	<p>
		Happy Coding!<br />
		The C2KB Team
	</p>
    </form>
</body>
</html>
