using AcceptedProject.Domain.DTOs;
using AcceptedProject.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace AcceptedProject.Infrastructure.Repositories
{
    public class MatchRepository : IMatchRepository
    {
        protected readonly ApplicationContext _context;
        public MatchRepository(ApplicationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public void Create(Match entity)
        {
            _context.Match.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            Match entity = GetById(id);
            if (entity != null)
            {
                _context.Match.Remove(entity);
                _context.SaveChanges();
            }
        }

        public void Update(int id, Match entity)
        {
            Delete(id);
            _context.Match.Update(entity);
            _context.SaveChanges();
        }

        public Match GetById(int id)
        {
            var matches = _context.Match.Where(x => x.Id == id).Include(x => x.MatchOdds);
            return matches.FirstOrDefault();
        }
    }
}
