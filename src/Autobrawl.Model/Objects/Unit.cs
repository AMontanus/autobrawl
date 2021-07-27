namespace Autobrawl.Model
{
    public class Unit
    {
        public Unit()
        {
            MaxHealth = Card.BaseHealth;
            CurrentHealth = Card.BaseHealth;
            MaxAttack = Card.BaseAttack;
            CurrentAttack = Card.BaseAttack;
            Keywords = Card.Keywords;
        }

        public Guid ID { get; set; }

        public int MaxHealth { get; set; }
        public int CurrentHealth { get; set; }

        public int MaxAttack { get; set; }
        public int CurrentAttack { get; set; }

        public Keywords Keywords { get; set; }

        [Required]
        public Card Card { get; set; }

    }
}
