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
            //string values = Request.Form["option"];

            int listVerification = 0;

            List<string> values = new List<string>();

            foreach(string key in Request.Form.AllKeys)
            {
                if (key.StartsWith("option") && Request.Form[key].Length > 0)
                {
                    //Label1.Text += Request.Form[key] + "<br/>";

                    values.Add(Request.Form[key]);
                    listVerification++;
                }
            }

            if(values.Count > 2)
            {
                //PollBuilding buildPoll = new PollBuilding();

                //buildPoll.
            }
            else
            {
                Label1.Text = "Error: Access denied";
            }

        }
    }
}