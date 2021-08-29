namespace Autobrawl.Model.Objects;
public class Card
{
    [Required]
    public int ID { get; set; }
    [Required]
    public string Name { get; set; }

    public string FlavourText { get; set; }

    [Required]
    public int BaseAttack { get; set; }
    [Required]
    public int BaseHealth { get; set; }
    [Required]
    public int Level { get; set; }

    [Required]
    public Aspect Aspect { get; set; }

    public Keywords Keywords { get; set; }
}
