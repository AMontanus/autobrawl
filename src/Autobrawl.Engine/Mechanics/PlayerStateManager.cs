using Autobrawl.Engine.Interfaces;

namespace Autobrawl.Engine.Mechanics;
public class PlayerStateManager : IPlayerStateManager
{

    public List<Player> Players { get; set; }

    public Level LevelUp(Level level)
    {
        if (level < Level.Six)
            return level.Next();
        else
            return level;
    }

    public int DealDamage(int hp, int dmg)
    {
        int newHp = hp - dmg;
        return newHp <= 0 ? 0 : newHp;
    }
}