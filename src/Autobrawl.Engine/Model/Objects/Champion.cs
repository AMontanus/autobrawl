namespace Autobrawl.Engine.Model;
public class Champion : IEquatable<Champion>
{
    [Key, Required]
    public int ID { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string AbilityDescription { get; set; }

    [Required]
    public Aspect Aspect {  get; set; }

    public bool Equals(Champion other)
    {
        if (other is null)
            return false;
        
        return other.ID == ID;
    }

    public override bool Equals(object obj) => Equals(obj as Champion);

    public override int GetHashCode() => ID;
}