namespace Autobrawl.Model.Constants;

public static partial class Constants
{
    /// <summary>
    /// Aspect: Normal (0)
    /// Utility and cross-aspect enabling cards - Aspect is always available.
    /// </summary>
    public static List<Card> AllNormalCards //TODO: Move Distract build from Normal to Earth.
    {
        get
        {
            List<Card> cards = new()
            {
                //Level 1
                new Card { ID = 1011, Aspect = Aspect.Normal, Level = Level.One, Name = "", BaseAttack = 2, BaseHealth = 2, Keywords = Keywords.LastStand & Keywords.Distract, Text = "" },
                new Card { ID = 1012, Aspect = Aspect.Normal, Level = Level.One, Name = "", BaseAttack = 2, BaseHealth = 3, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Give another friendly unit +1/+1" },
                new Card { ID = 1013, Aspect = Aspect.Normal, Level = Level.One, Name = "", BaseAttack = 1, BaseHealth = 4, Keywords = Keywords.Inspire, Text = $"{Keywords.Inspire}: Reduce enemy units' health by 1" },

                //Level 2
                new Card { ID = 1021, Aspect = Aspect.Normal, Level = Level.Two, Name = "", BaseAttack = 3, BaseHealth = 4, Keywords = Keywords.Survivor, Text = $"{Keywords.Survivor}: Gain 2 health" },
                new Card { ID = 1022, Aspect = Aspect.Normal, Level = Level.Two, Name = "", BaseAttack = 2, BaseHealth = 1, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Give another friendly unit Rebuff" },
                new Card { ID = 1023, Aspect = Aspect.Normal, Level = Level.Two, Name = "", BaseAttack = 2, BaseHealth = 2, Keywords = Keywords.CurtainCall, Text = $"{Keywords.CurtainCall}: Give your other units +1/+1" },

                //Level 3
                new Card { ID = 1031, Aspect = Aspect.Normal, Level = Level.Three, Name = "", BaseAttack = 5, BaseHealth = 2, Keywords = Keywords.Rebuff & Keywords.Distract, Text = $"" },
                new Card { ID = 1032, Aspect = Aspect.Normal, Level = Level.Three, Name = "", BaseAttack = 3, BaseHealth = 5, Keywords = Keywords.Survivor, Text = $"{Keywords.Survivor}: Add a random level 2 card to your hand" },
                new Card { ID = 1033, Aspect = Aspect.Normal, Level = Level.Three, Name = "", BaseAttack = 4, BaseHealth = 4, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Add a Mana droplet to your hand" },

                //Level 4
                new Card { ID = 1041, Aspect = Aspect.Normal, Level = Level.Four, Name = "", BaseAttack = 3, BaseHealth = 3, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Give a friendly unit of each Aspect +2/+2" },
                new Card { ID = 1042, Aspect = Aspect.Normal, Level = Level.Four, Name = "", BaseAttack = 4, BaseHealth = 4, Keywords = Keywords.None, Text = $"Every time one of your units with {Keywords.Distract} is attacked, gain +1/+1 permanently" },
                new Card { ID = 1043, Aspect = Aspect.Normal, Level = Level.Four, Name = "", BaseAttack = 2, BaseHealth = 6, Keywords = Keywords.Survivor & Keywords.Camouflage, Text = $"{Keywords.Survivor}: Give a random friendly unit +2/+4" },

                //Level 5
                new Card { ID = 1051, Aspect = Aspect.Normal, Level = Level.Five, Name = "", BaseAttack = 2, BaseHealth = 4, Keywords = Keywords.None, Text = $"Your {Keywords.Invoke}s trigger an additional time" },
                new Card { ID = 1052, Aspect = Aspect.Normal, Level = Level.Five, Name = "", BaseAttack = 1, BaseHealth = 10, Keywords = Keywords.None, Text = $"Your {Keywords.CurtainCall}s trigger an additional time" },
                new Card { ID = 1053, Aspect = Aspect.Normal, Level = Level.Five, Name = "", BaseAttack = 4, BaseHealth = 4, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Give your units with {Keywords.Distract} +2/+2" },

                //Level 6
                new Card { ID = 1061, Aspect = Aspect.Normal, Level = Level.Six, Name = "", BaseAttack = 1, BaseHealth = 5, Keywords = Keywords.Lethal & Keywords.LastStand, Text = $"" },
                new Card { ID = 1062, Aspect = Aspect.Normal, Level = Level.Six, Name = "", BaseAttack = 8, BaseHealth = 10, Keywords = Keywords.Fervor & Keywords.Overkill, Text = $"Always attacks the enemy with the lowest amount of attack. {Keywords.Overkill}: Permanently gain +3/+1" },
                new Card { ID = 1063, Aspect = Aspect.Normal, Level = Level.Six, Name = "", BaseAttack = 5, BaseHealth = 5, Keywords = Keywords.Neutralize & Keywords.Rebuff & Keywords.Fervor, Text = $"" }
            };

            return cards;
        }
    }
}
