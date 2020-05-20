using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingForm
{
    public class PollBuilding
    {
        public string BuildPoll(List<string> pollValues)
        {
            DateTime currentDate = DateTime.Now;

            if (currentDate != null)
            {
                Entity.Poll poll = new Entity.Poll();
                poll.pollOption = new List<Entity.Option>();

                poll.IdPoll = "poll" + currentDate.Ticks.ToString();
                poll.title = pollValues[0];

                for(int i = 1; i < pollValues.Count; i++)
                {
                    Entity.Option option = new Entity.Option();
                    
                    option.idOption = "option" + currentDate.Ticks.ToString() + "-" + i;
                    option.question = pollValues[i];

                    poll.pollOption.Add(option);
                }

                DAO.VotingFormBase sendPoll = new DAO.VotingFormBase();

                bool noErrorPoll = sendPoll.CreatePoll(poll);
                bool noErrorOptions = false;

                if (noErrorPoll)
                {
                    noErrorOptions = sendPoll.CreatePollOptions(poll);
                }

                if(noErrorPoll && noErrorOptions)
                {
                    return poll.IdPoll;
                }
            }

            return "error";
        }
    }
}