namespace Autobrawl.Engine.Mechanics;
public class MatchManager
{
    public MatchManager()
    {
        Match = new();
        PhaseManager = new();
        AvailableAspects = AspectFunctions.Rummage();
    }

    public List<Aspect> AvailableAspects { get; set; }
    public Match Match {  get; set; }
    public ChampionManager ChampionManager { get; set; }
    public Draft Draft { get; set; }
    public GameStateManager GameStateManager { get; set; }
    public PhaseManager PhaseManager { get; set; }
    public RoundManager RoundManager { get; set; }

    public void EndMatch()
    {
        Match.End = DateTime.UtcNow;
        Match.IsActive = false;
    }
}