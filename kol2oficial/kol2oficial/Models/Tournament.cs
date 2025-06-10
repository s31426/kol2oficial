using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace kol2oficial.Models;


[Table("Tournament")]
public class Tournament
{
    [Key]
    public int TournamentId { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; } = null!;
    
    public DateTime? StartDate { get; set; }
    
    public DateTime? EndDate { get; set; }
    
    ICollection<Match> matches { get; set; } = null!;
}