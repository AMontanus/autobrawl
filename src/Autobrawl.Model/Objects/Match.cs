using Autobrawl.Model.Enums;

namespace Autobrawl.Model;
public class Match
{
    public Match()
    {
        ID = Guid.NewGuid();
        Players = new HashSet<Player>();
        RemainingPlayers = Players;
        AvailableChampions = new HashSet<Champion>();
        SelectedChampions = new HashSet<Champion>();
        AvailableAspects = new HashSet<Aspect>();
    }

    [Required]
    [Key]
    public Guid ID { get; set; }

    public DateTime StartDateTime { get; private set; }

    public DateTime EndDateTime { get; private set; }

    public bool IsActive { get; private set; }

    public Phase CurrentPhase {  get; private set; }

    public ICollection<Player> Players { get; set; }
    public ICollection<Player> RemainingPlayers { get; set; }
    public ICollection<Champion> AvailableChampions { get; set; }
    public ICollection<Champion> SelectedChampions { get; set; }
    public ICollection<Aspect> AvailableAspects { get; set; }

    public void StartMatch()
    {
        StartDateTime = DateTime.UtcNow;
        IsActive = true;
    }

    public void EndMatch()
    {
        EndDateTime = DateTime.UtcNow;
        IsActive = false;
    }
}