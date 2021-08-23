namespace Autobrawl.Model.Enums;
[Flags]
public enum Keywords
{
    None = 0,

    CurtainCall = 1 << 0,
    Inspire = 1 << 1,
    Invoke = 1 << 2,
    Rebuff = 1 << 3,
    Survivor = 1 << 4,
    Fervor = 1 << 5,
    Overkill = 1 << 6,
    LastStand = 1 << 7,

    Camouflage = 1 << 8,
    Cleave = 1 << 9,
    Neutralize = 1 << 10,
    Lethal = 1 << 11,
    Distract = 1 << 12,
    StartOfTurn = 1 << 13,
    EndOfTurn = 1 << 14,
}
