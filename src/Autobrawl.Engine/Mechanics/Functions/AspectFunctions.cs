namespace Autobrawl.Engine.Mechanics;
public static class AspectFunctions
{
    private const int ASPECTS_PER_GAME = 5;

    public static List<Aspect> Rummage()
    {
        var aspects = Enum
                   .GetValues(typeof(Aspect))
                   .Cast<Aspect>()
                   .Where(a => a != Aspect.Normal)
                   .OrderBy(_ => Guid.NewGuid())
                   .Take(ASPECTS_PER_GAME)
                   .ToList();
        aspects.Add(Aspect.Normal);

        return aspects;
    }
}