//namespace Autobrawl.Engine.Mechanics;

//public static class ChampionFunctions
//{
//    private static readonly ChampionManager championManager = ChampionManager.Instance;

//    public static IEnumerable<Champion> ServeChampionChoices(int choices)
//    {
//        var selection = championManager.AvailableChampions
//            .OrderBy(_ => Guid.NewGuid())
//            .Take(choices);

//        championManager.MakeUnavailable(selection);
//        return selection;
//    }

//    public static Champion SelectChampion(int championId)
//        => championManager.AvailableChampions.Find(c => c.ID == championId);
//}