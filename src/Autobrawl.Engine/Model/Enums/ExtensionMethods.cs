namespace Autobrawl.Engine.Model;
public static class Extensions
{
    public static T Next<T>(this T src)
        where T : Enum
    {
        T[] Arr = (T[])Enum.GetValues(src.GetType());
        int j = Array.IndexOf<T>(Arr, src) + 1;
        return (Arr.Length == j) ? Arr[0] : Arr[j];
    }

    public static IEnumerable<Card> GetCardTypes(this Aspect aspect)
        => aspect switch
        {
            Aspect.Normal => Constants.AllNormalCards(),
            Aspect.Fire => Constants.AllFireCards(),
            Aspect.Water => Constants.AllWaterCards,
            Aspect.Earth => Constants.AllEarthCards,
            Aspect.Air => Constants.AllAirCards,
            Aspect.Death => Constants.AllDeathCards,
            Aspect.Shadow => Constants.AllShadowCards,
            Aspect.Lightning => Constants.AllLightCards,
            Aspect.Nature => Constants.AllNatureCards,
            Aspect.Psychic => Constants.AllNatureCards,
            _ => throw new ArgumentOutOfRangeException(nameof(aspect))
        };

    public static int GetNoOfCopies(this Level level)
        => level switch
        {
            Level.One => 18,
            Level.Two => 16,
            Level.Three => 14,
            Level.Four => 12,
            Level.Five => 10,
            Level.Six => 8,
            _ => throw new ArgumentOutOfRangeException(nameof(level))
        };
}