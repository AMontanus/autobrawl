namespace Autobrawl.Engine.Mechanics;
public class ChampionManager
{
    private static readonly List<Champion> ALL_CHAMPIONS = Constants.AllChampions;
    private const int CHOICES_PER_PLAYER = 3;

    public ChampionManager()
    {
    }

    public static List<Player> AllocateChampionChoices(List<Player> players)
    {
        List<Champion> availableChampions = ALL_CHAMPIONS;

        foreach (var player in players)
        {
            var selection = Rummage(availableChampions);
            player.ChampionChoices = selection.ToList();
            foreach (var choice in selection)
            {
                availableChampions.Remove(choice);
            }
                
        }

        return players;
    }

    private static List<Champion> Rummage(List<Champion> availableChamps)
    {
        return availableChamps.OrderBy(r => Guid.NewGuid()).Take(CHOICES_PER_PLAYER).ToList();
    }
}