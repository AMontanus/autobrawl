using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Autobrawl.Engine.Mechanics.Managers;
public sealed class CardStateManager
{
    private static readonly Lazy<CardStateManager> _lazy = new(() => new CardStateManager());
    public static CardStateManager Instance => _lazy.Value;

    private CardStateManager()
    {
        //Testing with just these two for PoC - should use gamestatemanager aspects.
        List<Aspect> aspects = new();
        aspects.Add(Aspect.Normal);
        aspects.Add(Aspect.Fire);
        _ = FillBag(aspects);

       //GameStateManager gameState = GameStateManager.Instance;
       // _ = FillBag(gameState.AvailableAspects);
    }

    public ConcurrentBag<Card> Deck { get; set; } = new();

    //TODO: Ensure that drawn cards are returned?
    public IEnumerable<Card> Draw(int noOfCards)
    {
        List<Card> cards = new();
        for (int i = 0; i < noOfCards; i++)
        {
            _ = Deck.TryTake(out var card);
            cards.Add(card);
        }

        return cards;
    }

    public void Return(IEnumerable<Card> cards)
    {
        foreach(var card in cards)
            Deck.Add(card);
    }

    //TODO: Add
    private void Shuffle()
    {

    }


    private Task FillBag(IEnumerable<Aspect> aspects)
    {
        List<Card> deck = new();

        foreach (var aspect in aspects)
            deck.AddRange(aspect.GetCardTypes());

        SeedDeck(deck);

        return Task.CompletedTask;
    }

    private void SeedDeck(IEnumerable<Card> cards)
    {
        var levels = Enum.GetValues<Level>();

        foreach (var level in levels)
            SeedDeckByLevel(level, cards.Where(c => c.Level == level));
    }

    private void SeedDeckByLevel(Level level, IEnumerable<Card> cards)
    {
        foreach (var card in cards)
            for (int i = 0; i < level.GetNoOfCopies(); i++)
                Deck.Add(card);
    }
}