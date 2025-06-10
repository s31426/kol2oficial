using kol2oficial.DTOs;

namespace kol2oficial.Services;

public interface IDbService
{
    Task<FinalDTO> GetMatchesById(int matchId);
}