using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingForm.Entity
{
    public class Poll
    {
        private string IdPoll { get; set; }

        private string title { get; set; }

        private List<Option> pollOption { get; set; }
    }
}