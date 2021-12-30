namespace Autobrawl.Engine.Model;
public class Champion
{
    [Key, Required]
    public int ID { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string AbilityDescription { get; set; }

    [Required]
    public Aspect Aspect {  get; set; }
}