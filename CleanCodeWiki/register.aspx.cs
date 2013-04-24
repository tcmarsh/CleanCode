using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CleanCodeWiki
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            submitregistration.Click += SubmitRegistration_Click;
        }

        private void SubmitRegistration_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = true;
            if (regUserName.Value == string.Empty)
            {
                errorLabel.Text = "Username is a required field";
                return;
            }
            else if (regPassword.Value != regConfirmPassword.Value || regPassword.Value == string.Empty)
            {
                errorLabel.Text = "Passwords are required and must match.";
                return;
            }
            else if (string.IsNullOrEmpty(lastName.Value))
            {
                errorLabel.Text = "Last name is a required field";
                return;
            }
            else
            {
                errorLabel.Visible = false;
                user user = DataAccess.Register(regUserName.Value, regPassword.Value, lastName.Value, null);
                Server.Transfer(string.Format("index.aspx?newRegisteredUserName={0}", user.last_name));
            }
        }
    }
}