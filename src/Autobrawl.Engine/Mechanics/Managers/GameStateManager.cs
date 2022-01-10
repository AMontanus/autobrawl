namespace Autobrawl.Engine.Mechanics;
public sealed class GameStateManager
{
    private static readonly Lazy<GameStateManager> _lazy = new(() => new GameStateManager());
    public static GameStateManager Instance => _lazy.Value;

    private GameStateManager()
    {
        AvailableAspects = AspectFunctions.Rummage();
    }

    public List<Aspect> AvailableAspects { get; set; }
}