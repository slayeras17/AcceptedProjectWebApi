using AcceptedProject.Application.Interfaces;
using AcceptedProject.Domain;
using AcceptedProject.Domain.DTOs;
using AcceptedProject.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AcceptedProject.Application
{
    public class MatchMapper : IMatchMapper
    {
        public Match Map(Game game)
        {
            var odds = new List<MatchOdd>();

            foreach(var item in game.GameOdds)
            {
                odds.Add(new MatchOdd
                {
                    Specifier = item.Specifier,
                    Odd = item.Odd
                });
            }

            var match = new Match
            {
                Description = game.Description,
                MatchDate = DateTime.Parse(game.MatchDateTime).Date, // DateTime.Parse(game.MatchDateTime.ToShortDateString()).Date,
                MatchTime = DateTime.Parse(game.MatchDateTime).TimeOfDay, // DateTime.Parse(game.MatchTime.ToShortTimeString()),
                TeamA = game.TeamA,
                TeamB = game.TeamB,
                Sport = (int)game.Sport,
                MatchOdds = odds
            };

            return match;
        }
             
        public Game Map(Match match)
        {
            var gameOdds = new List<GameOdd>();

            foreach(var matchOdd in match.MatchOdds)
            {
                var gameOdd = new GameOdd();
                gameOdd.Odd = matchOdd.Odd;
                gameOdd.Specifier = matchOdd.Specifier;

                gameOdds.Add(gameOdd);
            }

            var game = new Game
            {
                Description = match.Description,
                MatchDateTime = string.Format("{0} {1}", match.MatchDate, match.MatchTime),
                TeamA = match.TeamA,
                TeamB = match.TeamB,
                Sport = (Sport)match.Sport,
                GameOdds = gameOdds
            };

            return game;
        }
    }
}
