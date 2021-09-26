namespace Autobrawl.Model.Constants;

public static partial class Constants
{
    /// <summary>
    /// Aspect: Water (2)
    /// </summary>
    public static List<Card> AllWaterCards
    {
        get
        {
            List<Card> cards = new()
            {
                //Level 1
                new Card { ID = 1211, Aspect = Aspect.Water, Level = Level.One, Name = "", BaseAttack = 1, BaseHealth = 1, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Summon two 1/1 droplets" },
                new Card { ID = 1212, Aspect = Aspect.Water, Level = Level.One, Name = "", BaseAttack = 2, BaseHealth = 2, Keywords = Keywords.Overflow, Text = $"{Keywords.Overflow} (2): Permanently gain +1/+1" },
                new Card { ID = 1213, Aspect = Aspect.Water, Level = Level.One, Name = "", BaseAttack = 2, BaseHealth = 3, Keywords = Keywords.LastStand, Text = $"" },

                //Level 2
                new Card { ID = 1221, Aspect = Aspect.Water, Level = Level.Two, Name = "", BaseAttack = 3, BaseHealth = 4, Keywords = Keywords.Inspire, Text = $"{Keywords.Inspire}: Permanently give your {Aspect.Water} units 2 attack" },
                new Card { ID = 1222, Aspect = Aspect.Water, Level = Level.Two, Name = "", BaseAttack = 2, BaseHealth = 2, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Summon 1/1 dropslets for each attack this unit has" },
                new Card { ID = 1223, Aspect = Aspect.Water, Level = Level.Two, Name = "", BaseAttack = 3, BaseHealth = 1, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Summon a 2/3 droplet with {Keywords.Distract}" },

                //Level 3
                new Card { ID = 1231, Aspect = Aspect.Water, Level = Level.Three, Name = "", BaseAttack = 2, BaseHealth = 4, Keywords = Keywords.Overflow, Text = $"{Keywords.Overflow} (1): Give your other {Aspect.Water} units +1/+1" },
                new Card { ID = 1232, Aspect = Aspect.Water, Level = Level.Three, Name = "", BaseAttack = 3, BaseHealth = 3, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Give another {Aspect.Water} unit +2/+2 and {Keywords.Distract}" },
                new Card { ID = 1233, Aspect = Aspect.Water, Level = Level.Three, Name = "", BaseAttack = 4, BaseHealth = 2, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Add a snowball to your hand" }, //Snowball: Castable on friendly Water unit, gives +2/+2

            };

            return cards;
        }
    }
}