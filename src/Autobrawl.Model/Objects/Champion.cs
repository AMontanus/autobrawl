namespace Autobrawl.Model;
public class Champion
{
    [Required]
    [Key]
    public int ID { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string AbilityDescription { get; set; }
}