using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingForm
{
    public class PollBuilding
    {
        public bool BuildPoll(List<string> pollValues)
        {
            DateTime currentDate = DateTime.Now;

            if (currentDate != null)
            {
                Entity.Poll poll = new Entity.Poll();

                poll.IdPoll = "poll" + currentDate.ToString();
                poll.title = pollValues[0];

                for(int i = 1; i < pollValues.Count; i++)
                {
                    Entity.Option option = new Entity.Option();

                    option.idOption = "option" + currentDate.ToString() + "-" + i;
                    option.question = pollValues[i];

                    poll.pollOption.Add(option);
                }

                
            }

            return false;
        }
    }
}