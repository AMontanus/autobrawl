namespace Autobrawl.Engine.Model;
[Flags]
public enum Keywords
{
    None = 0,

    /// <summary>
    /// Combat: On unit death
    /// </summary>
    CurtainCall = 1 << 0,

    /// <summary>
    /// Combat: On start of combat
    /// </summary>
    Inspire = 1 << 1,

    /// <summary>
    /// Draft: On entering board from hand
    /// </summary>
    Invoke = 1 << 2,

    /// <summary>
    /// Combat: Ignore first instance of damage
    /// </summary>
    Rebuff = 1 << 3,

    /// <summary>
    /// Combat: Triggers if alive at end of combat
    /// </summary>
    Survivor = 1 << 4,

    /// <summary>
    /// Combat: Attacks twice in a row
    /// </summary>
    Fervor = 1 << 5,

    /// <summary>
    /// Combat: On dealing higher damage than target's health
    /// </summary>
    Overkill = 1 << 6,

    /// <summary>
    /// Combat: Survive lethal damage with 1 health
    /// </summary>
    LastStand = 1 << 7,

    /// <summary>
    /// Combat: Cannot be directly attacked before attacking
    /// </summary>
    Camouflage = 1 << 8,

    /// <summary>
    /// Combat: Attacks target and unit adjacent to the left of target
    /// </summary>
    Cleave = 1 << 9,

    /// <summary>
    /// Combat: Eliminates target's effects before attack/event lands
    /// </summary>
    Neutralize = 1 << 10,

    /// <summary>
    /// Combat: Ignore target's health
    /// </summary>
    Lethal = 1 << 11,

    /// <summary>
    /// Combat: Takes priority when enemy units attack
    /// </summary>
    Distract = 1 << 12,

    /// <summary>
    /// Draft: Occurs at start of phase
    /// </summary>
    StartOfTurn = 1 << 13,

    /// <summary>
    /// Draft: Occurs at end of phase
    /// </summary>
    EndOfTurn = 1 << 14,

    #region Aspect Keywords

    /// <summary>
    /// <see cref="Aspect.Fire"/> Draft: Whenever another Fire card is played
    /// </summary>
    HotStreak = 1 << 15,

    /// <summary>
    /// <see cref="Aspect.Lightning"/> Draft: Merge with another Lightning unit
    /// </summary>
    Static = 1 << 16,

    /// <summary>
    /// <see cref="Aspect.Earth"/> Combat: When X friendly Earth unit(s) dies
    /// </summary>
    Aftershock = 1 << 17,

    /// <summary>
    /// <see cref="Aspect.Water"/> Combat: When you summon X Water units
    /// </summary>
    Overflow = 1 << 18,


    /// <summary>
    /// <see cref="Aspect.Air"/> Combat: Whenever a friendly Air unit attacks
    /// </summary>
    Updraft = 1 << 19,

    /// <summary>
    /// <see cref="Aspect.Shadow"/> Draft/Combat: For each other Shadow unit
    /// </summary>
    Blend = 1 << 20, //TODO: How to word this for card text?


    #endregion
}