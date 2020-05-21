using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingForm
{
    public partial class RequestPoll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            inpLinkPoll.Visible = false;
            string value = Request.QueryString["value"];

            if(value != null && value != string.Empty && value != "error")
            {
                statusMessage.Text = "Success";

                pollLink.Text = "BuildPoll.aspx/?value=" + value;

                inpLinkPoll.Visible = true;
            }
            else
            {
                statusMessage.Text = "Failed request";
            }

        }
    }
}