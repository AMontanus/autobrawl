using Autobrawl.Engine.Mechanics.Functions;

namespace Autobrawl.Engine.Mechanics;
public class MatchManager
{
    public MatchManager()
    {
        Match = new();
        DraftManager = new();
        PhaseManager = new();
        AvailableAspects = AspectFunctions.Rummage().ToList();
    }

    public List<Aspect> AvailableAspects { get; set; }
    public Match Match {  get; set; }
    public ChampionManager ChampionManager { get; set; }
    public DraftManager DraftManager { get; set; }
    public GameStateManager GameStateManager { get; set; }
    public PhaseManager PhaseManager { get; set; }
    public PlayerStateManager PlayerStateManager { get; set; }
    public RoundManager RoundManager { get; set; }


    public void EndMatch()
    {
        Match.End = DateTime.UtcNow;
        Match.IsActive = false;
    }
}