namespace Autobrawl.Engine.Mechanics;
public class MatchManager
{
    public MatchManager()
    {
        Match = new();
        PhaseManager = new();
    }

    public Match Match {  get; set; }
    public ChampionManager ChampionManager { get; set; }
    public Draft Draft { get; set; }
    public static GameStateManager GameStateManager => GameStateManager.Instance;
    public PhaseManager PhaseManager { get; set; }
    public RoundManager RoundManager { get; set; }

    public void EndMatch()
    {
        Match.End = DateTime.UtcNow;
        Match.IsActive = false;
    }
}