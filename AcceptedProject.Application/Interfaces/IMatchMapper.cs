using AcceptedProject.Domain;
using AcceptedProject.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcceptedProject.Application.Interfaces
{
    public interface IMatchMapper
    {
        public Match Map(Game match);
        public Game Map(Match match);
    }
}
