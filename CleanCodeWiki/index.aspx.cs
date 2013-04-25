using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CleanCodeWiki
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string newUserName = Request.QueryString["newRegisteredUserName"];
            userloggedin.Visible = false;
            if (!string.IsNullOrEmpty(newUserName))
            {
                userloggedin.Visible = true;
                userloggedin.Text = string.Format("Welcome {0}!", newUserName);
            }
            login.Click += Login_Click;
            register.Click += Register_Click;
        }

        internal void Login_Click(object sender, EventArgs e)
        {
			if (login.Text == "Log out")
			{
				userloggedin.Text = string.Empty;
				login.Text = "Log in";
				return;
			}

            string usrname;
            string pass;
            user returnUser;
            usrname = username.Value;
            pass = mypassword.Value;
            userloggedin.Visible = true;

            if (usrname == string.Empty || pass == string.Empty)
            {
                userloggedin.Text = "Username and password are required fields";
                return;
            }
            try
            {
                returnUser = DataAccess.Login(usrname, pass);
            }
            catch (InvalidOperationException exception)
            {
                returnUser = null;
                userloggedin.Text = "Sorry, incorrect username or password";
            }

            if (returnUser != null)
            {
                userloggedin.Text = string.Format("Welcome {0}!", returnUser.last_name);
				login.Text = "Log out";
            }

            else
            {
                userloggedin.Text = "Sorry, incorrect username or password";
            }

        }

        internal void Register_Click(object sender, EventArgs e)
        {
            Server.Transfer("register.aspx");
        }
    }
}