using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace VotingForm.DAO
{
    public class VotingFormBase
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings[""].ConnectionString);

        public void CreatePoll(string tittle)
        {

        }

        public void CreatePollOptions(List<string> options)
        {

        }

        public DataTable GetPoll(string idPoll)
        {
            return null;
        }

        public bool CheckIP(string IPCod)
        {
            return false;
        }
    }
}