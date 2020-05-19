using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingForm.Entity
{
    public class Poll
    {
        public string IdPoll { get; set; }

        public string title { get; set; }

        public List<Option> pollOption { get; set; }
    }
}