namespace kol2oficial.DTOs;

public class FinalDTO
{
  
    public PlayerDTO Player { get; set; }
    public List<PlayerMatchesDTO> PlayerMatches { get; set; }
}
public class PlayerMatchesDTO
{
    public TournamentDTO? Tournament { get; set; }
    public MapDTO? Map { get; set; }
    public matchDTO? Match { get; set; }
}

public class PlayerDTO
{
    public int playerId { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public DateTime birthDate { get; set; }
}

public class matchDTO
{
    public DateTime MatchDate { get; set; }
    public int team1Score { get; set; }
    public int team2Score { get; set; }
}

public class TournamentDTO
{
    public string tournamentName { get; set; }
}

public class MapDTO
{
    public string mapName { get; set; }
}