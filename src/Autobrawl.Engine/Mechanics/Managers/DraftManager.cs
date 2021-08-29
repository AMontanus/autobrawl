namespace Autobrawl.Engine.Mechanics;
public class DraftManager
{
    public DraftManager()
    {
        Draft = new();
    }

    public Draft Draft { get; private set; }

    public void IncrementDraftTime()
    {
        int updatedDraftTime = Math.Min(Draft.MaxDraftTime, Draft.DraftTime + Draft.AddedPerRound);
        Draft.DraftTime = updatedDraftTime;
    }
}