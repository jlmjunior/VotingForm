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
            string values = Request.Form["option"];

            if (values != null)
            {
                Label1.Text = values;
            }
            else
            {
                Label1.Text = "Error: Access denied";
            }
        }
    }
}