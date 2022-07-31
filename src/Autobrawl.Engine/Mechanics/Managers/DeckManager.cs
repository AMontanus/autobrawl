using Autobrawl.Engine.Config;
using Microsoft.Extensions.Options;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Autobrawl.Engine.Mechanics;

public class DeckManager
{
    private readonly DeckOptions _options;
    
    public DeckManager(IOptions<DeckOptions> options)
    {
        _options = options.Value;
    }

    /// <summary>
    /// Key is card, Value is number of copies
    /// </summary>
    public ConcurrentDictionary<Card, int> Deck { get; } = new();

    /// <summary>
    /// Buy a <paramref name="card"/> from the drawn lot.
    /// </summary>
    public void Buy(Card card)
    {
        var currentCount = Deck[card];
        _ = Deck.TryUpdate(card, currentCount--, currentCount);
    }

    /// <summary>
    /// Draw <paramref name="noOfCards"/> from the deck.
    /// </summary>
    public IEnumerable<Card> Draw(int noOfCards)
    {
        Random random = new();
        for (int i = 0; i < noOfCards; i++)
        {
            var size = Deck.Count;
            yield return Deck.ElementAt(random.Next(0, size - 1)).Key;
        }
    }

    /// <summary>
    /// Return <paramref name="cards"/> to the deck
    /// </summary>
    public void Return(params Card[] cards)
    {
        foreach(var card in cards)
        {
            var currentCount = Deck[card];
            _ = Deck.TryUpdate(card, currentCount++, currentCount);
        }
    }

    public async Task<int> FillBag(IEnumerable<Aspect> aspects)
    {
        List<Card> cards = new();

        foreach (var aspect in aspects)
            cards.AddRange(aspect.GetAssociatedCards());

        var levels = new Dictionary<int, int>()
        {
            { 1, _options.CopiesLvlOne },
            { 2, _options.CopiesLvlTwo },
            { 3, _options.CopiesLvlThree },
            { 4, _options.CopiesLvlFour },
            { 5, _options.CopiesLvlFive },
            { 6, _options.CopiesLvlSix },
        };

        foreach (var level in levels)
        {
            foreach (var card in cards)
                await Task.Run(() => _ = Deck.TryAdd(card, level.Value));
        }

        return cards.Count;
    }
}