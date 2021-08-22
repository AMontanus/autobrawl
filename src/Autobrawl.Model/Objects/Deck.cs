namespace Autobrawl.Model.Objects;

public class Deck
{
    [Required]
    [Key]
    public Guid ID { get; set; }

    [Required]
    public ICollection<Aspect> AvailableAspects { get; set; }

    [Required]
    public ICollection<Card> AvailableCards { get; set; }
}
