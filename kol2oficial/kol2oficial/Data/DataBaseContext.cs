using kol2oficial.Models;
using Microsoft.EntityFrameworkCore;

namespace kol2oficial.Data;

public class DataBaseContext : DbContext
{
    
    public DbSet<Player> Players { get; set; }
    public DbSet<Player_Match> Player_Matchs { get; set; }
    public DbSet<Match> Matchs { get; set; }
    public DbSet<Map> Maps { get; set; }
    public DbSet<Tournament> Tournaments { get; set; }
    protected DataBaseContext()
    {
        
    }
    public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>().HasData(new List<Player>()
        {
            new Player() { PlayerId = 1, FirstName = "John", LastName = "Doe", BirthDate = DateTime.Now.AddYears(-30) },
            new Player() { PlayerId = 2, FirstName = "Jane", LastName = "Doe", BirthDate = DateTime.Now.AddYears(-30) },
            new Player() { PlayerId = 3, FirstName = "Julie", LastName = "Doe", BirthDate = DateTime.Now.AddYears(-30) },
        });
        
        modelBuilder.Entity<Player_Match>().HasData(new List<Player_Match>()
        {
            new Player_Match() { MatchId = 1,PlayerId = 1, MVPs = 2, Rating = 2 },
            new Player_Match() { MatchId = 2,PlayerId = 2, MVPs = 2, Rating = 2 },
            new Player_Match() {  MatchId = 3,PlayerId = 3, MVPs = 2, Rating = 2 },
        });
        
        modelBuilder.Entity<Match>().HasData(new List<Match>()
        {
            new Match() { MatchId = 1, TournamentId = 1, MapId = 1, MatchDate = DateTime.Now.AddYears(-30), Team1Score = 1 , Team2Score = 0 ,BestRating = 2},
            new Match() { MatchId = 2, TournamentId = 2, MapId = 1, MatchDate = DateTime.Now.AddYears(-30), Team1Score = 1 , Team2Score = 0 ,BestRating = 2},
            new Match() { MatchId = 3, TournamentId = 3, MapId = 1,MatchDate = DateTime.Now.AddYears(-30), Team1Score = 1 , Team2Score = 0 ,BestRating = 2 },
        });
        
        modelBuilder.Entity<Tournament>().HasData(new List<Tournament>()
        {
            new Tournament() { TournamentId = 1, Name = "dwadwada", StartDate = DateTime.Parse("2025-05-02"), EndDate = DateTime.Parse("2025-05-02") },
            new Tournament() { TournamentId = 2, Name = "dwadwada", StartDate = DateTime.Parse("2025-05-02"), EndDate = DateTime.Parse("2025-05-02") },
            new Tournament() { TournamentId = 3,  Name = "dwadwada", StartDate = DateTime.Parse("2025-05-02"), EndDate = DateTime.Parse("2025-05-02") },
        });
        
        modelBuilder.Entity<Map>().HasData(new List<Map>()
        {
            new Map() { MapId = 1, Name = "dwa", Type = "dwa"},
            new Map() { MapId = 2,Name = "dwa", Type = "dwa"},
            new Map() { MapId = 3, Name = "dwa", Type = "dwa"},
        });
    }
}