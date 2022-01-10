namespace Autobrawl.Engine.Mechanics;
public sealed class ChampionManager
{
    private static readonly Lazy<ChampionManager> lazy = new(() => new ChampionManager());

    public static ChampionManager Instance => lazy.Value;

    public static IEnumerable<Champion> Rummage(IEnumerable<Champion> availableChamps, int choices)
    {
        return availableChamps.OrderBy(r => Guid.NewGuid()).Take(choices);
    }
}