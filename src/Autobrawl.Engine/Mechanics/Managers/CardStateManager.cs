namespace Autobrawl.Engine.Mechanics.Managers;
public class CardStateManager
{
    public CardStateManager()
    {

    }



    public List<Card> Cards { get; set; } = new();

    private static IEnumerable<Card> FetchCards(Aspect aspect) => aspect switch
    {
        Aspect.Normal => Constants.AllNormalCards,
        Aspect.Fire => Constants.AllFireCards,
        Aspect.Water => throw new NotImplementedException(),
        Aspect.Earth => throw new NotImplementedException(),
        Aspect.Air => throw new NotImplementedException(),
        Aspect.Death => throw new NotImplementedException(),
        Aspect.Shadow => throw new NotImplementedException(),
        Aspect.Light => throw new NotImplementedException(),
        Aspect.Nature => throw new NotImplementedException(),
        Aspect.Psychic => throw new NotImplementedException(),
        _ => throw new ArgumentOutOfRangeException(nameof(aspect))
    };

    public static IEnumerable<Card> Draft(IEnumerable<Aspect> aspects)
    {
        List<Card> deck = new();

        foreach (var aspect in aspects)
            deck.AddRange(FetchCards(aspect));

        return deck;
    }
}

