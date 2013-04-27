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
            submitregistration.Click += SubmitRegistration_Click;
        }

        private void SubmitRegistration_Click(object sender, EventArgs e)
        {
            if(regPassword.Value != regPassword.Value || regPassword.Value == string.Empty)
            {
                //error label set to visible
                return;
            }
            //Register(regUserName.Value, regPassword.Value);
            //redirect to home page with label set to username.
        }
    }
}