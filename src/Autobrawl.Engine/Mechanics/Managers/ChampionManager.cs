namespace Autobrawl.Engine.Mechanics;
public sealed class ChampionManager
{
    private static readonly Lazy<ChampionManager> lazy = new(() => new ChampionManager());

    public static ChampionManager Instance => lazy.Value;

        foreach (var player in players)
        {
            var selection = Rummage(ALL_CHAMPIONS.Where(c => !usedChampionIds.Contains(c.ID)));
            player.ChampionChoices = selection.ToList();
            foreach (var choice in selection)
                usedChampionIds.Add(choice.ID);
        }

        return players;
    }

    private static IEnumerable<Champion> Rummage(IEnumerable<Champion> availableChamps)
    {
        return availableChamps.OrderBy(r => Guid.NewGuid()).Take(CHOICES_PER_PLAYER);
    }
}