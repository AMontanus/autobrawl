namespace Autobrawl.Engine.Mechanics;
public sealed class ChampionManager
{
    private static readonly Lazy<ChampionManager> lazy = new(() => new ChampionManager());

    public static ChampionManager Instance { get { return lazy.Value; } }

    private ChampionManager()
    {
    }
    public List<Champion> AvailableChampions { get; private set; } = Constants.AllChampions;

    public void MakeUnavailable(IEnumerable<Champion> champions)
        => AvailableChampions = AvailableChampions.Except(champions).ToList();
}