using AcceptedProject.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcceptedProject.Application.Interfaces
{
    public interface IMatchManager
    {
        public void AddMatch(Game match);
        public Game GetMatch(int id);
        public void UpdateMatch(int id, Game game);
        public void DeleteMatch(int id);
    }
}
