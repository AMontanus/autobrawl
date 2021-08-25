namespace Autobrawl.Model;
public class Player
{
    [Required]
    [Key]
    public Guid ID { get; set; }

    public int PlayerNo { get; set; }

    public Level Level { get; set; }

    public int MaxHealth { get; set; }
    public int Health { get; set; }
    public int Mana { get; set; }
    public int HandSize { get; set; }
    public int LevelCost { get; set; }

    public int Placement { get; set; }

    public Board Board { get; set; }
    public GameUser User { get; set; }
    public Hand Hand { get; set; }
}