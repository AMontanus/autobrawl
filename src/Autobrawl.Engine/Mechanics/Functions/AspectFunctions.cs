namespace Autobrawl.Engine.Mechanics.Functions;
public class AspectFunctions
{
    private const int ASPECTS_PER_GAME = 6;

    public static List<Aspect> Rummage() => Enum.GetValues(typeof(Aspect)).Cast<Aspect>().OrderBy(a => Guid.NewGuid()).Take(ASPECTS_PER_GAME).ToList();
}