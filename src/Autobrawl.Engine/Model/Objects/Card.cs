namespace Autobrawl.Engine.Model;
public record struct Card
{
    /// <summary>
    /// [1][Aspect][Level][Order]
    /// </summary>
    [Required]
    public int ID { get; init; }
    [Required]
    public string Name { get; init; }

    public string Text { get; init; }

    [Required]
    public int BaseAttack { get; init; }
    [Required]
    public int BaseHealth { get; init; }
    [Required]
    public int Level { get; init; }

    [Required]
    public Aspect Aspect { get; init; }

    public Keywords Keywords { get; init; }

    public override string ToString()
    {
        return $"ID: [{ID}]\nName: [{Name}]\nAspect: [{Aspect}]";
    }
}