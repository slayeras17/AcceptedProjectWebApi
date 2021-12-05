
using AcceptedProject.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcceptedProject.Domain.Interfaces
{
    public interface IMatchRepository
    {
        Match GetById(int id);
        void Create(Match entity);
        void Update(int id, Match entity);
        void Delete(int id);
    }
}
