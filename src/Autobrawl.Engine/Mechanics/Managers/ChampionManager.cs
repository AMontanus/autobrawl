namespace Autobrawl.Engine.Mechanics;
public class ChampionManager
{
    private static readonly List<Champion> ALL_CHAMPIONS = Constants.AllChampions;
    private static readonly int CHOICES_PER_PLAYER = 3;

    public ChampionManager()
    {
    }

    public static List<Player> AllocateChampionChoices(List<Player> players)
    {
        List<int> usedChampionIds = new();

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