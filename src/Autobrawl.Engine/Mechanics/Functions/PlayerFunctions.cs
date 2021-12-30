namespace Autobrawl.Engine.Mechanics;
public static class PlayerFunctions
{
    public static Level LevelUp(this Player player)
        => player.Level < Level.Six
            ? player.Level.Next()
            : player.Level;

    public static int DealDamage(this Player player, int dmg)
        => player.Health - dmg > 0
            ? player.Health - dmg
            : 0;
}