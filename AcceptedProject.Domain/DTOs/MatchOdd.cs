using System;
using System.Collections.Generic;
using System.Text;

namespace AcceptedProject.Domain.DTOs
{
    public class MatchOdd : BaseEnity
    {
        public string Specifier { get; set; }
        public double Odd { get; set; }
        public Match Match { get; set; }
        public int MatchId { get; set; }
    }
}
