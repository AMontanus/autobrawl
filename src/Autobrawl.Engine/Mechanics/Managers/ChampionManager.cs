namespace Autobrawl.Engine.Mechanics;

public class ChampionManager
{
    public static IEnumerable<Champion> Rummage(IEnumerable<Champion> availableChamps, int choices)
    {
        return availableChamps.OrderBy(r => Guid.NewGuid()).Take(choices);
    }
}