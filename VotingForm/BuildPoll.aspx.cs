using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingForm
{
    public partial class BuildPoll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string value = Request.QueryString["value"];

            if(value != null && value != string.Empty)
            {
                DAO.VotingFormBase dao = new DAO.VotingFormBase();

                if (dao.DetectPoll(value))
                {
                    
                }
                else
                {
                    Label1.Text = "Ops: Poll not found";
                }
            }
            else
            {
                Label1.Text = "Error: invalid value";
            }
        }
    }
}