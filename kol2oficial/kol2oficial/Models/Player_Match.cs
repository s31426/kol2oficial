using System.ComponentModel.DataAnnotations.Schema;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace kol2oficial.Models;
[Table("Player_Match")]
[PrimaryKey(nameof(PlayerId), nameof(MatchId))]
public class Player_Match
{
    [ForeignKey(nameof(Player))]
    public int PlayerId { get; set; }
    [ForeignKey(nameof(Match))]
    public int MatchId { get; set; }
    
    public int MVPs { get; set; }
    
    public Player Player { get; set; } = null!;
    public Match Match { get; set; } = null!;
    
    [Column(TypeName = "decimal")]
    [Precision(4, 2)]
    public decimal Rating { get; set; }
}