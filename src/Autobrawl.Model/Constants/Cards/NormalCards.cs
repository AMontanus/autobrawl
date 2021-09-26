namespace Autobrawl.Model.Constants;

public static partial class Constants
{
    //Level 1
    public static readonly Card Normal1011 = new() { ID = 1011, Aspect = Aspect.Normal, Level = Level.One, Name = "", BaseAttack = 2, BaseHealth = 2, Keywords = Keywords.LastStand & Keywords.Distract, Text = "" };
    public static readonly Card Normal1012 = new() { ID = 1012, Aspect = Aspect.Normal, Level = Level.One, Name = "", BaseAttack = 2, BaseHealth = 3, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Give another friendly unit +1/+1" };
    public static readonly Card Normal1013 = new() { ID = 1013, Aspect = Aspect.Normal, Level = Level.One, Name = "", BaseAttack = 1, BaseHealth = 4, Keywords = Keywords.Inspire, Text = $"{Keywords.Inspire}: Reduce enemy units' health by 1" };

    //Level 2
    public static readonly Card Normal1021 = new() { ID = 1021, Aspect = Aspect.Normal, Level = Level.Two, Name = "", BaseAttack = 3, BaseHealth = 4, Keywords = Keywords.Survivor, Text = $"{Keywords.Survivor}: Gain 2 health" };
    public static readonly Card Normal1022 = new() { ID = 1022, Aspect = Aspect.Normal, Level = Level.Two, Name = "", BaseAttack = 2, BaseHealth = 1, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Give another friendly unit Rebuff" };
    public static readonly Card Normal1023 = new() { ID = 1023, Aspect = Aspect.Normal, Level = Level.Two, Name = "", BaseAttack = 2, BaseHealth = 2, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Give your other units +1/+1" };
    
    //Level 3
    public static readonly Card Normal1031 = new() { ID = 1031, Aspect = Aspect.Normal, Level = Level.Three, Name = "", BaseAttack = 5, BaseHealth = 2, Keywords = Keywords.Rebuff & Keywords.Distract, Text = $"" };
    public static readonly Card Normal1032 = new() { ID = 1032, Aspect = Aspect.Normal, Level = Level.Three, Name = "", BaseAttack = 3, BaseHealth = 5, Keywords = Keywords.Survivor, Text = $"{Keywords.Survivor}: Add a random level 2 card to your hand" };
    public static readonly Card Normal1033 = new() { ID = 1033, Aspect = Aspect.Normal, Level = Level.Three, Name = "", BaseAttack = 4, BaseHealth = 4, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Add a Mana droplet to your hand" };
    
    //Level 4
    public static readonly Card Normal1041 = new() { ID = 1041, Aspect = Aspect.Normal, Level = Level.Four, Name = "", BaseAttack = 3, BaseHealth = 3, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Give a friendly unit of each Aspect +2/+2" };
    public static readonly Card Normal1042 = new() { ID = 1042, Aspect = Aspect.Normal, Level = Level.Four, Name = "", BaseAttack = 4, BaseHealth = 4, Keywords = Keywords.None, Text = $"Every time one of your units with {Keywords.Distract} is attacked, gain +1/+1 permanently" };
    public static readonly Card Normal1043 = new() { ID = 1043, Aspect = Aspect.Normal, Level = Level.Four, Name = "", BaseAttack = 2, BaseHealth = 6, Keywords = Keywords.Survivor & Keywords.Camouflage, Text = $"{Keywords.Survivor}: Give a random friendly unit +2/+4" };
    
    //Level 5
    public static readonly Card Normal1051 = new() { ID = 1051, Aspect = Aspect.Normal, Level = Level.Five, Name = "", BaseAttack = 2, BaseHealth = 4, Keywords = Keywords.None, Text = $"Your {Keywords.Invoke}s trigger an additional time" };
    public static readonly Card Normal1052 = new() { ID = 1052, Aspect = Aspect.Normal, Level = Level.Five, Name = "", BaseAttack = 1, BaseHealth = 10, Keywords = Keywords.None, Text = $"Your {Keywords.CurtainCall}s trigger an additional time" };
    public static readonly Card Normal1053 = new() { ID = 1053, Aspect = Aspect.Normal, Level = Level.Five, Name = "", BaseAttack = 4, BaseHealth = 4, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Give your units with {Keywords.Distract} +2/+2" };
    
    //Level 6
    public static readonly Card Normal1061 = new() { ID = 1061, Aspect = Aspect.Normal, Level = Level.Six, Name = "", BaseAttack = 1, BaseHealth = 5, Keywords = Keywords.Lethal & Keywords.LastStand, Text = $"" };
    public static readonly Card Normal1062 = new() { ID = 1062, Aspect = Aspect.Normal, Level = Level.Six, Name = "", BaseAttack = 8, BaseHealth = 10, Keywords = Keywords.Fervor & Keywords.Overkill, Text = $"Always attacks the enemy with the lowest amount of attack. {Keywords.Overkill}: Permanently gain +3/+1" };
    public static readonly Card Normal1063 = new() { ID = 1063, Aspect = Aspect.Normal, Level = Level.Six, Name = "", BaseAttack = 5, BaseHealth = 5, Keywords = Keywords.Neutralize & Keywords.Rebuff & Keywords.Fervor, Text = $"" };


    /// <summary>
    /// Aspect: Normal (0)
    /// Utility and cross-aspect enabling cards - Aspect is always available.
    /// </summary>
    public static List<Card> AllNormalCards()
    {
        List<Card> cards = new()
        {
            Normal1011,
            Normal1012,
            Normal1013,
            Normal1021,
            Normal1022,
            Normal1023,
            Normal1031,
            Normal1032,
            Normal1033,
            Normal1041,
            Normal1042,
            Normal1043,
            Normal1051,
            Normal1052,
            Normal1053,
            Normal1061,
            Normal1062,
            Normal1063,
        };

        return cards;
    }
}