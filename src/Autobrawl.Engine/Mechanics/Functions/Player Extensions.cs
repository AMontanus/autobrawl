namespace Autobrawl.Engine.Mechanics;
public static class PlayerExtensions
{
    public static int LevelUp(this Player player)
        => player.Level < 6
            ? player.Level = player.Level++
            : player.Level;

    public static int DealDamage(this Player player, int dmg)
        => player.Health - dmg > 0
            ? player.Health - dmg
            : 0;
}