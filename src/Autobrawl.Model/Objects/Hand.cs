namespace Autobrawl.Model.Objects;
public class Hand
{
    public Hand()
    {
        Cards = new HashSet<Card>();
    }

    [Required]
    public int CardCount { get; set; }
    public ICollection<Card> Cards { get; set; }
}
