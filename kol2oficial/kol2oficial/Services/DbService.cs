using kol2oficial.Data;
using kol2oficial.DTOs;
using Microsoft.EntityFrameworkCore;

namespace kol2oficial.Services;

public class DbService : IDbService
{
    private readonly DataBaseContext _context;

    public DbService(DataBaseContext context)
    {
        _context = context;
    }

    public async Task<FinalDTO> GetMatchesById(int playerId)
    {
        //var final = await _context.Player_Matchs.Select(
           // e => new FinalDTO
            //{
              //  Player = new PlayerDTO()
                //{
                  //  firstName = e.Player.FirstName,
                    //lastName = e.Player.LastName,
                   // birthDate = e.Player.BirthDate,
                   //  },
                   //   PlayerMatches = e.Match.Player_Matchs.Select(e => new PlayerMatchesDTO()
                   //   {
                   //     Tournament = new TournamentDTO()
                    //       {
                    //          tournamentName = e.Match.TournamentId,
                    //      },
                    //    Map = new MapDTO()
                    //    {
                    //          mapName = e.Match.Map.Name,
                    //   },
                    //   Match = new matchDTO()
                    //   {
                        //       MatchDate = e.Match.MatchDate,
                        //       team1Score = e.Match.Team1Score,
                        //         team2Score = e.Match.Team2Score,
                        //      }
                        //   }).ToList()
       //     }).FirstOrDefault(e => e.matchId == matchId);
        return null;
    }
}