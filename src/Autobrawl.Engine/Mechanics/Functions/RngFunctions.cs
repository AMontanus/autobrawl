namespace Autobrawl.Engine.Mechanics.Functions;
public class RngFunctions
{
    private RngFunctions()
    {

    }

    public static RngFunctions Create()
    {
        return new RngFunctions();
    }

    private static Random random = new();

    
}