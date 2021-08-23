namespace Autobrawl.Model;
public class Player
{
    public int ID { get; set; }

    public Level Level { get; set; }

    public int Mana { get; set; }
    public int HandSize { get; set; }
    public int LevelCost { get; set; }

    public Board Board { get; set; }
    public GameUser User { get; set; }
    public Hand Hand { get; set; }
}