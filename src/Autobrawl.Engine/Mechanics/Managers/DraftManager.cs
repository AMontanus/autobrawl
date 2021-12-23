namespace Autobrawl.Engine.Mechanics;
public class DraftManager
{
    public DraftManager()
    {
        Draft = new();
    }

    public Draft Draft { get; }
}