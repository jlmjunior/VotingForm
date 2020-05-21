using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingForm
{
    public partial class wkeIOWAQJEO7345634LQLWej12312PPQKW : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int listVerification = 0;
            string link;

            List<string> values = new List<string>();

            foreach (string key in Request.Form.AllKeys)
            {
                if (key.StartsWith("option") && Request.Form[key].Length > 0)
                {
                    //Label1.Text += Request.Form[key] + "<br/>";

                    values.Add(Request.Form[key]);
                    listVerification++;
                }
            }

            if (values.Count > 2)
            {
                PollBuilding exec = new PollBuilding();
                string adressPoll = exec.BuildPoll(values);

                if (adressPoll != "error")
                {
                    link = adressPoll;
                }
                else
                {
                    link = "Error";
                }
            }
            else
            {
                link = "Error: Access denied";
            }

            Response.Redirect("RequestPoll.aspx/?value=" + link);
        }
    }
}