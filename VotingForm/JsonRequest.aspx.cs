using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VotingForm
{
    public partial class JsonRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            errorPanel.Visible = false;
            string value;

            try
            {
                value = Request.QueryString["value"];
            }
            catch (Exception ex)
            {
                Response.ClearHeaders();
                Response.Write("<h2 class=\"display - 4\">Request Block</h1>");
                Response.End();
                value = string.Empty;
            }
            
            if(value != null && value != string.Empty)
            {
                Entity.Option option = new Entity.Option();
                DAO.VotingFormBase dao = new DAO.VotingFormBase();

                option.idOption = value;
                option.votes = dao.GetVotesOption(value);

                string jsonObject = JsonConvert.SerializeObject(option);

                Response.Clear();
                Response.ContentType = "application/json";
                Response.Write(jsonObject);
                Response.End();
            }
        }
    }
}