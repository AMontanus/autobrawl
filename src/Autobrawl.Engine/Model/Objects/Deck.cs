namespace Autobrawl.Engine.Model;

public class Deck
{
    [Key, Required]
    public Guid ID { get; } = Guid.NewGuid();

    [Required]
    public ICollection<Aspect> AvailableAspects { get; set; }

    [Required]
    public ICollection<Card> AvailableCards { get; set; }
}