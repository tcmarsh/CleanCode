using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace CleanCodeWiki
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            login.Click += Login_Click;
            register.Click += Register_Click;

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string usrname;
            string pass;
            usrname = IsEmail(username.Value) ? username.Value : string.Empty;
            pass = mypassword.Value;

            if (usrname == string.Empty || pass == string.Empty)
            {
                //set invalid label
                return;
            }

            //User user = LogIn(usrname, pass);
            //if (user.HasValue)
            //{

            //}
            
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (username.Value != string.Empty && mypassword.Value != string.Empty)
            {
                Server.Transfer("register.aspx");
            }
            else
            {
                //set invalid label
            }
        }

        private bool IsEmail( string usrname)
        {
            //test for email string
            return true;
        }
    }
}