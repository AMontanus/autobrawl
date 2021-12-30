namespace Autobrawl.Engine.Model;
public class Match
{
    public Match()
    {
        Players = new List<Player>();
        RemainingPlayers = Players;
        AvailableChampions = new List<Champion>();
        SelectedChampions = new List<Champion>();
        AvailableAspects = new List<Aspect>();

        IsActive = true;
    }

    [Key, Required]
    public Guid ID { get; } = Guid.NewGuid();

    public DateTime Start { get; } = DateTime.UtcNow;

    public DateTime End { get; set; }

    public bool IsActive { get; set; }

    public List<Player> Players { get; set; }
    public List<Player> RemainingPlayers { get; set; }
    public List<Champion> AvailableChampions { get; set; }
    public List<Champion> SelectedChampions { get; set; }
    public List<Aspect> AvailableAspects { get; set; }
}