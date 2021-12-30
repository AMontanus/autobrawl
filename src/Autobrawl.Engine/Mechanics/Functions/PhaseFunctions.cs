namespace Autobrawl.Engine.Mechanics;

internal static class PhaseFunctions
{
    public static Phase ChangePhase(this Phase currentPhase)
        => currentPhase switch
        {
            Phase.Combat or Phase.Selection => Phase.Draft,
            Phase.Draft => Phase.Combat,
            _ => Phase.Draft,
        };
}