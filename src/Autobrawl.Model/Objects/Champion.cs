namespace Autobrawl.Model.Objects;
public class Champion
{
    public Champion()
    {

    }

    [Required]
    [Key]
    public int ID { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string AbilityDescription { get; set; }

    [Required]
    public Aspect Aspect {  get; set; }
}