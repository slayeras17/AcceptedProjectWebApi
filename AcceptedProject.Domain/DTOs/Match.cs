using System;
using System.Collections.Generic;
using System.Text;

namespace AcceptedProject.Domain.DTOs
{
    public class Match : BaseEnity
    {
        public string Description { get; set; }
        public DateTime MatchDate { get; set; }
        public TimeSpan MatchTime { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public int Sport { get; set; }
        public List<MatchOdd> MatchOdds { get; set; }
    }
}
