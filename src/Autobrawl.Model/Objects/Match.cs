namespace Autobrawl.Model;
public class Match
{
    public Match()
    {
        ID = Guid.NewGuid();
        Players = new List<Player>();
        RemainingPlayers = Players;
        AvailableChampions = new List<Champion>();
        SelectedChampions = new List<Champion>();
        AvailableAspects = new List<Aspect>();

        StartDateTime = DateTime.UtcNow;
        IsActive = true;
    }

    [Required]
    [Key]
    public Guid ID { get; set; }

    public DateTime StartDateTime { get; private set; }

    public DateTime EndDateTime { get; set; }

    public bool IsActive { get; set; }

    public List<Player> Players { get; set; }
    public List<Player> RemainingPlayers { get; set; }
    public List<Champion> AvailableChampions { get; set; }
    public List<Champion> SelectedChampions { get; set; }
    public List<Aspect> AvailableAspects { get; set; }
}