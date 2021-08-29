namespace Autobrawl.Engine.Mechanics.Functions;
public class AspectFunctions
{
    private static readonly int ASPECTS_PER_GAME = 6;

    public Task<IEnumerable<Aspect>> SelectAspects()
    {
        IEnumerable<Aspect> aspects = Enum.GetValues(typeof(Aspect)).Cast<Aspect>();
    }
}