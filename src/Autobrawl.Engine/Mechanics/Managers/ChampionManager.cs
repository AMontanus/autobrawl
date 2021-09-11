namespace Autobrawl.Engine.Mechanics;
public class ChampionManager
{
    private static readonly List<Champion> ALL_CHAMPIONS = Constants.AllChampions;
    private static readonly int CHOICES_PER_PLAYER = 3;

    public ChampionManager()
    {
    }

    private static List<Champion> usedChampions = new();

    public static List<Player> AllocateChampionChoices(List<Player> players)
    {
        foreach (var player in players)
        {
            var selection = Rummage(ALL_CHAMPIONS.Except(usedChampions));
            player.ChampionChoices = selection.ToList();
            foreach (var choice in selection)
                usedChampions.Add(choice);
        }

        return players;
    }

    private static IEnumerable<Champion> Rummage(IEnumerable<Champion> availableChamps)
    {
        return availableChamps.OrderBy(r => Guid.NewGuid()).Take(CHOICES_PER_PLAYER);
    }
}