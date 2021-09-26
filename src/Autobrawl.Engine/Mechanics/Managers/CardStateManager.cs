namespace Autobrawl.Engine.Mechanics.Managers;
public class CardStateManager
{
    public CardStateManager()
    {

    }



    public List<Card> Cards { get; set; } = new();

    

    public static IEnumerable<Card> Draft(IEnumerable<Aspect> aspects)
    {
        List<Card> deck = new();

        foreach (var aspect in aspects)
            deck.AddRange(FetchCards(aspect));

        return deck;
    }

    private static IEnumerable<Card> FetchCards(Aspect aspect) => aspect switch
    {
        Aspect.Normal => Constants.AllNormalCards,
        Aspect.Fire => Constants.GetAllFireCards(),
        Aspect.Water => Constants.AllWaterCards,
        Aspect.Earth => Constants.AllEarthCards,
        Aspect.Air => Constants.AllAirCards,
        Aspect.Death => Constants.AllDeathCards,
        Aspect.Shadow => Constants.AllShadowCards,
        Aspect.Light => Constants.AllLightCards,
        Aspect.Nature => Constants.AllNatureCards,
        Aspect.Psychic => Constants.AllNatureCards,
        _ => throw new ArgumentOutOfRangeException(nameof(aspect))
    };
}