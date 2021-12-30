namespace Autobrawl.Engine.Model;
public class Unit
{
    public Unit(Card card)
    {
        Card = card;
        MaxHealth = Card.BaseHealth;
        CurrentHealth = Card.BaseHealth;
        MaxAttack = Card.BaseAttack;
        CurrentAttack = Card.BaseAttack;
        Keywords = Card.Keywords;
    }

    [Key, Required]
    public Guid ID { get; } = Guid.NewGuid();

    public int MaxHealth { get; set; }

    public int CurrentHealth { get; set; }

    public int MaxAttack { get; set; }

    public int CurrentAttack { get; set; }

    public Keywords Keywords { get; set; }

    [Required]
    public Card Card { get; }
}