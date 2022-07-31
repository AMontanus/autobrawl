namespace Autobrawl.Engine.Model;

public enum Phase
{
    Selection,
    Draft,
    Combat
}

public static class PhaseExtensions
{
    public static Phase ChangePhase(this Phase currentPhase)
        => currentPhase switch
        {
            Phase.Combat or Phase.Selection => Phase.Draft,
            Phase.Draft => Phase.Combat,
            _ => Phase.Draft,
        };
}