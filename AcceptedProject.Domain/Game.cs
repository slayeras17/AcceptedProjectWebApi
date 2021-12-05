using AcceptedProject.Domain.Enums;
using System;
using System.Collections.Generic;

namespace AcceptedProject.Domain
{
    public class Game
    {
        public string Description { get; set; }
        public string MatchDateTime { get; set; }
        public string TeamA { get; set; }
        public string TeamB { get; set; }
        public Sport Sport { get; set; }
        public List<GameOdd> GameOdds { get; set; }
    }
}
