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
                DAO.VotingFormBase dao = new DAO.VotingFormBase();

                dao.SendVote(value);
            }
        }
    }
}