using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingForm
{
    public partial class SendVote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Request.Form["value"];

            if(value != null && value != string.Empty)
            {
                string userIp = string.Empty;

                if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
                {
                    userIp = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
                }
                else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
                {
                    userIp = HttpContext.Current.Request.UserHostAddress;
                }

                int index = userIp.IndexOf(':');

                if(index > 0)
                {
                    userIp = userIp.Substring(0, index);
                }

                DAO.VotingFormBase dao = new DAO.VotingFormBase();

                if (dao.CheckIP(userIp, value))
                {
                    dao.SendVote(value);
                    dao.SendIP(userIp, value);
                }

            }
        }
    }
}