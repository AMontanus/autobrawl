namespace Autobrawl.Engine.Mechanics;

public class PhaseManager
{
    public Phase CurrentPhase { get; private set; }

    public void ChangePhase() => CurrentPhase.ChangePhase();
}