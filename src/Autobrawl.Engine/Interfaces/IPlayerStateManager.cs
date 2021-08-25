namespace Autobrawl.Engine.Interfaces;
public interface IPlayerStateManager
{
    Level LevelUp(Level level);
    int DealDamage(int hp, int dmg);
}
