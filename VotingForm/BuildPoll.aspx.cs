using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingForm
{
    public partial class BuildPoll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorPanel.Visible = false;
            successPanel.Visible = false;

            string value = Request.QueryString["value"];

            if(value != null && value != string.Empty)
            {
                DAO.VotingFormBase dao = new DAO.VotingFormBase();

                if (dao.DetectPoll(value))
                {
                    PollBuilding exec = new PollBuilding();
                    Entity.Poll poll = exec.RequestPoll(value);

                    if (poll != null)
                    {
                        #region PAGE BUILD

                        pollTitle.Text = poll.title;

                        StringBuilder sb = new StringBuilder();

                        sb.Append("<div class=\"list-group\">");

                        foreach (Entity.Option option in poll.pollOption)
                        {
                            sb.Append("<button  type=\"button\" class=\"list-group-item list-group-item-action d-flex justify-content-between align-items-center\" >" + option.question );
                            sb.Append("<span class=\"badge badge-primary badge-pill\" >" + option.votes + "</span>");
                            sb.Append("</button>");
                        }

                        sb.Append("</div>");

                        litOptions.Text = sb.ToString();

                        successPanel.Visible = true;

                        #endregion
                    }
                    else
                    {
                        errorMessage.Text = "Failed to create poll";
                        errorPanel.Visible = true;
                    }
                }
                else
                {
                    errorMessage.Text = "Poll not found";
                    errorPanel.Visible = true;
                }
            }
            else
            {
                errorMessage.Text = "Invalid value";
                errorPanel.Visible = true;
            }
        }

        [WebMethod]
        public static int RequestVotesOption(string idOption)
        {
            DAO.VotingFormBase dao = new DAO.VotingFormBase();

            return dao.GetVotesOption(idOption);
        }
    }
}