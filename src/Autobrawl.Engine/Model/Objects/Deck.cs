namespace Autobrawl.Engine.Model;

public sealed class Deck
{
    private static readonly Lazy<Deck> lazy = new(() => new Deck());

    public static Deck Instance => lazy.Value;

    private Deck()
    {
    }

    public ICollection<Aspect> Aspects { get; set; }

    public ICollection<Card> AvailableCards { get; set; }
}