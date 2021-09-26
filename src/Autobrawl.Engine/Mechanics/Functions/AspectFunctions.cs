namespace Autobrawl.Engine.Mechanics.Functions;
public class AspectFunctions
{
    private const int ASPECTS_PER_GAME = 6;

    public static IEnumerable<Aspect> Rummage()
    {
        return Enum.GetValues(typeof(Aspect)).Cast<Aspect>().OrderBy(a => Guid.NewGuid()).Take(ASPECTS_PER_GAME);
    }
}