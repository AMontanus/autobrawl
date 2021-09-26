namespace Autobrawl.Model.Constants;

public static partial class Constants
{
    //Level 1
    public static readonly Card Water1211 = new() { ID = 1211, Aspect = Aspect.Water, Level = Level.One, Name = "", BaseAttack = 1, BaseHealth = 1, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Summon two 1/1 droplets" };
    public static readonly Card Water1212 = new() { ID = 1212, Aspect = Aspect.Water, Level = Level.One, Name = "", BaseAttack = 2, BaseHealth = 2, Keywords = Keywords.Overflow, Text = $"{Keywords.Overflow} (2): Permanently gain +1/+1" };
    public static readonly Card Water1213 = new() { ID = 1213, Aspect = Aspect.Water, Level = Level.One, Name = "", BaseAttack = 2, BaseHealth = 3, Keywords = Keywords.LastStand, Text = $"" };
    
    //Level 2
    public static readonly Card Water1221 = new() { ID = 1221, Aspect = Aspect.Water, Level = Level.Two, Name = "", BaseAttack = 3, BaseHealth = 4, Keywords = Keywords.Inspire, Text = $"{Keywords.Inspire}: Permanently give your {Aspect.Water} units 2 attack" };
    public static readonly Card Water1222 = new() { ID = 1222, Aspect = Aspect.Water, Level = Level.Two, Name = "", BaseAttack = 2, BaseHealth = 2, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Summon 1/1 dropslets for each attack this unit has" };
    public static readonly Card Water1223 = new() { ID = 1223, Aspect = Aspect.Water, Level = Level.Two, Name = "", BaseAttack = 3, BaseHealth = 1, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Summon a 2/3 droplet with {Keywords.Distract}" };
    
    //Level 3
    public static readonly Card Water1231 = new() { ID = 1231, Aspect = Aspect.Water, Level = Level.Three, Name = "", BaseAttack = 2, BaseHealth = 4, Keywords = Keywords.Overflow, Text = $"{Keywords.Overflow} (1): Give your other {Aspect.Water} units +1/+1" };
    public static readonly Card Water1232 = new() { ID = 1232, Aspect = Aspect.Water, Level = Level.Three, Name = "", BaseAttack = 3, BaseHealth = 3, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Give another {Aspect.Water} unit +2/+2 and {Keywords.Distract}" };
    public static readonly Card Water1233 = new() { ID = 1233, Aspect = Aspect.Water, Level = Level.Three, Name = "", BaseAttack = 4, BaseHealth = 2, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Add a snowball to your hand" };
    
    //Level 4
    public static readonly Card Water1241 = new() { ID = 1241, Aspect = Aspect.Water, Level = Level.Four, Name = "", BaseAttack = 3, BaseHealth = 7, Keywords = Keywords.Camouflage & Keywords.Survivor, Text = $"{Keywords.Survivor}: Add 2 snowballs to your hand" };

    /// <summary>
    /// Aspect: Water (2)
    /// Combat buff oriented with tokens and curtaincall
    /// Special "spell" token. Snowball. Castable on friendly Water units to give it +2/+2
    /// </summary>
    public static List<Card> AllWaterCards
    {
        get
        {
            List<Card> cards = new()
            {
                Water1211,
                Water1212,
                Water1213,
                Water1221,
                Water1222,
                Water1223,
                Water1231,
                Water1232,
                Water1233,
                Water1241,
            };

            return cards;
        }
    }
}