using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VotingForm.Entity
{
    public class Option
    {
        public string idOption { get; set; }
        public string question { get; set; }
        public int votes { get; set; }
    }
}