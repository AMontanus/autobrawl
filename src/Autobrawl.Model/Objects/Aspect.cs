namespace Autobrawl.Model.Objects;
public class Aspect
{
    [Required]
    [Key]
    public int ID { get; set; }

    [Required]
    public string Name { get; set; }

    public ICollection<Card> Cards { get; set; }
}