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
        List<Champion> used = new();



        foreach (var player in players)
        {
            var selection = Rummage(ALL_CHAMPIONS.Except(used));
            player.ChampionChoices = selection.ToList();
            foreach (var choice in selection)
                used.Add(choice);
        }

        return players;
    }

    private static IEnumerable<Champion> Rummage(IEnumerable<Champion> availableChamps)
    {
        return availableChamps.OrderBy(r => Guid.NewGuid()).Take(CHOICES_PER_PLAYER);
    }
}