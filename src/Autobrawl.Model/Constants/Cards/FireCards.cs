namespace Autobrawl.Model.Constants;

public static partial class Constants
{
    /// <summary>
    /// Aspect: Fire (1)
    /// Built around playing more and more Fire cards
    /// </summary>
    public static List<Card> AllFireCards
    {
        get
        {
            List<Card> cards = new()
            {
                //Level 1
                new Card { ID = 1111, Aspect = Aspect.Fire, Level = Level.One, Name = "", BaseAttack = 1, BaseHealth = 4, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Your next refresh costs 0" },
                new Card { ID = 1112, Aspect = Aspect.Fire, Level = Level.One, Name = "", BaseAttack = 3, BaseHealth = 2, Keywords = Keywords.Overkill, Text = $"{Keywords.Overkill}: Permanently gain +1/+1" },
                new Card { ID = 1113, Aspect = Aspect.Fire, Level = Level.One, Name = "", BaseAttack = 2, BaseHealth = 2, Keywords = Keywords.Survivor, Text = $"{Keywords.Survivor}: Reduce the cost of leveling up by 1" },

                //Level 2
                new Card { ID = 1121, Aspect = Aspect.Fire, Level = Level.Two, Name = "", BaseAttack = 3, BaseHealth = 3, Keywords = Keywords.HotStreak, Text = $"{Keywords.HotStreak}: Give another {Aspect.Fire} unit +1/+1 " },
                new Card { ID = 1122, Aspect = Aspect.Fire, Level = Level.Two, Name = "", BaseAttack = 2, BaseHealth = 4, Keywords = Keywords.HotStreak & Keywords.Distract, Text = $"{Keywords.HotStreak}: Gain 1 health " },
                new Card { ID = 1123, Aspect = Aspect.Fire, Level = Level.Two, Name = "", BaseAttack = 2, BaseHealth = 3, Keywords = Keywords.EndOfTurn, Text = $"{Keywords.EndOfTurn}: Your next {Aspect.Fire} unit costs 1 less" },

                //Level 3
                new Card { ID = 1131, Aspect = Aspect.Fire, Level = Level.Three, Name = "", BaseAttack = 4, BaseHealth = 2, Keywords = Keywords.Rebuff & Keywords.Fervor, Text = $"" },
                new Card { ID = 1132, Aspect = Aspect.Fire, Level = Level.Three, Name = "", BaseAttack = 3, BaseHealth = 3, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Give another {Aspect.Fire} unit stats equal to your level" },
                new Card { ID = 1133, Aspect = Aspect.Fire, Level = Level.Three, Name = "", BaseAttack = 1, BaseHealth = 5, Keywords = Keywords.Survivor, Text = $"{Keywords.Survivor}: Add a random level 3 or lower {Aspect.Fire} card to your hand" },

                //Level 4
                new Card { ID = 1141, Aspect = Aspect.Fire, Level = Level.Four, Name = "", BaseAttack = 5, BaseHealth = 4, Keywords = Keywords.HotStreak, Text = $"{Keywords.HotStreak}: Your next refresh costs 0" },
                new Card { ID = 1142, Aspect = Aspect.Fire, Level = Level.Four, Name = "", BaseAttack = 4, BaseHealth = 6, Keywords = Keywords.Survivor & Keywords.LastStand, Text = $"{Keywords.Survivor}: Permanently give your {Aspect.Fire} units +3/+3" },
                new Card { ID = 1143, Aspect = Aspect.Fire, Level = Level.Four, Name = "", BaseAttack = 7, BaseHealth = 5, Keywords = Keywords.Cleave & Keywords.Overkill, Text = $"{Keywords.Overkill}: Permanently gain +2/+1" },

                //Level 5
                new Card { ID = 1151, Aspect = Aspect.Fire, Level = Level.Five, Name = "", BaseAttack = 4, BaseHealth = 4, Keywords = Keywords.HotStreak, Text = $"{Keywords.HotStreak}: All {Aspect.Fire} units permanently gain +1/+1" },
                new Card { ID = 1152, Aspect = Aspect.Fire, Level = Level.Five, Name = "", BaseAttack = 6, BaseHealth = 6, Keywords = Keywords.CurtainCall & Keywords.Distract, Text = $"{Keywords.CurtainCall}: Summon a random {Aspect.Fire} unit and add it to your hand" },
                new Card { ID = 1153, Aspect = Aspect.Fire, Level = Level.Five, Name = "", BaseAttack = 4, BaseHealth = 4, Keywords = Keywords.LastStand & Keywords.Rebuff & Keywords.Inspire, Text = $"{Keywords.Inspire}: Give a random friendly unit {Keywords.Rebuff}" },

                //TODO: 1161 and 1162 are too similar
                //Level 6
                new Card { ID = 1161, Aspect = Aspect.Fire, Level = Level.Six, Name = "", BaseAttack = 6, BaseHealth = 12, Keywords = Keywords.HotStreak & Keywords.Survivor, Text = $"{Keywords.HotStreak}: Gain stats equal to half the unit's stats. {Keywords.Survivor}: Your {Aspect.Fire} units cost 1 less during your next draft" },
                new Card { ID = 1162, Aspect = Aspect.Fire, Level = Level.Six, Name = "", BaseAttack = 8, BaseHealth = 8, Keywords = Keywords.HotStreak, Text = $"{Keywords.HotStreak}: Give a random friendly unit stats equal to the unit's stats" },
                new Card { ID = 1163, Aspect = Aspect.Fire, Level = Level.Six, Name = "", BaseAttack = 10, BaseHealth = 5, Keywords = Keywords.Neutralize & Keywords.Fervor & Keywords.Inspire, Text = $"{Keywords.Inspire}: Attack immediately" }
            };
            return cards;
        }
    }
}