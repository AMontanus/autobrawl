namespace Autobrawl.Engine.Mechanics;
public class PhaseManager
{
    private readonly Phase currentPhase;

    public Phase CurrentPhase
    {
        get => currentPhase;
        set => currentPhase.ChangePhase();
    }
}