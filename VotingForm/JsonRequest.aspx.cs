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
            string value = Request.QueryString["value"];

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