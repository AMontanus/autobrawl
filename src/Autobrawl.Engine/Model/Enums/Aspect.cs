namespace Autobrawl.Engine.Model;

public enum Aspect
{
    //Let's stick to familiar aspects like "elements" to begin with.

    Normal,

    Fire,
    Water,
    Earth,
    Air,
    Death,
    Shadow,
    Lightning,
    Nature,
    Psychic
}

public static class AspectExtensions
{
    public static IEnumerable<Card> GetAssociatedCards(this Aspect aspect)
        => aspect switch
        {
            Aspect.Normal => CardExtensions.AllNormalCards(),
            Aspect.Fire => CardExtensions.AllFireCards(),
            Aspect.Water => CardExtensions.AllWaterCards,
            Aspect.Earth => CardExtensions.AllEarthCards,
            Aspect.Air => CardExtensions.AllAirCards,
            Aspect.Death => CardExtensions.AllDeathCards,
            Aspect.Shadow => CardExtensions.AllShadowCards,
            Aspect.Lightning => CardExtensions.AllLightCards,
            Aspect.Nature => CardExtensions.AllNatureCards,
            Aspect.Psychic => CardExtensions.AllPsychicCards,
            _ => throw new ArgumentOutOfRangeException(nameof(aspect))
        };
}