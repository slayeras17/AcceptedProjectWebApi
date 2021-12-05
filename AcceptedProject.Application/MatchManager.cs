using AcceptedProject.Application.Interfaces;
using AcceptedProject.Domain;
using AcceptedProject.Domain.DTOs;
using AcceptedProject.Domain.Interfaces;
using System;

namespace AcceptedProject.Application
{
    public class MatchManager : IMatchManager
    {
        private readonly IMatchMapper _mapper;
        private readonly IMatchRepository _repo;
        public MatchManager(IMatchMapper mapper, IMatchRepository repo)
        {
            _mapper = mapper;
            _repo = repo;
        }


        public void AddMatch(Game game)
        {
            if (game == null)
                throw new ArgumentException(nameof(game));

            try
            {
                Match matchDto = _mapper.Map(game);
                _repo.Create(matchDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void DeleteMatch(int id)
        {
            if (id <= 0)
                throw new ArgumentException(nameof(id));

            try
            {
                _repo.Delete(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Game GetMatch(int id)
        {
            if (id <= 0)
                throw new ArgumentException(nameof(id));

            try
            {
                var match = _repo.GetById(id);
                Game game = _mapper.Map(match);
                return game;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateMatch(int id, Game game)
        {
            if (game == null)
                throw new ArgumentException(nameof(game));

            try
            {
                Match matchDto = _mapper.Map(game);
                _repo.Update(id,matchDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
