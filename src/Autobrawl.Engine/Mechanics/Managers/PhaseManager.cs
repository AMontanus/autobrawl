namespace Autobrawl.Engine.Mechanics;
public class PhaseManager
{
    private const Phase _initialPhase = Phase.Selection;

    public PhaseManager()
    {
        CurrentPhase = _initialPhase;
    }

    public Phase CurrentPhase { get; private set; }

    public void ChangePhase()
    {
        if (CurrentPhase == Phase.Selection)
            CurrentPhase = Phase.Draft;

        else if (CurrentPhase == Phase.Draft)
            CurrentPhase = Phase.Combat;

        else
            CurrentPhase = Phase.Draft;
    }
}