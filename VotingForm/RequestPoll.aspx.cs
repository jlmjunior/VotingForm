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
                PollBuilding exec = new PollBuilding();
                string adressPoll = exec.BuildPoll(values);

                if (adressPoll != "error")
                {
                    statusMessage.Text = "Sucess";
                    pollLink.Text = "BuildPoll.aspx/poll=" + adressPoll;

                    inpLinkPoll.Visible = true;
                }
                else
                {
                    statusMessage.Text = "Error";
                }
            }
            else
            {
                statusMessage.Text = "Error: Access denied";
            }

        }
    }
}