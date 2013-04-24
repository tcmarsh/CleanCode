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
            string usrname;
            string pass;
            usrname = username.Value;
            pass = mypassword.Value;
            userloggedin.Visible = true;

            if (usrname == string.Empty || pass == string.Empty)
            {
                userloggedin.Text = "Username and password are required fields";
                return;
            }

            user user = DataAccess.Login(usrname, pass);
            if (user != null)
            {
                userloggedin.Text = string.Format("Welcome {0}!", user.last_name);
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