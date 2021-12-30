namespace Autobrawl.Engine.Model;
public class Hand
{
    public Hand()
    {
        Cards = new HashSet<Card>();
    }

    [Required]
    public int CardCount { get => Cards.Count; }
    public ICollection<Card> Cards { get; set; }
}