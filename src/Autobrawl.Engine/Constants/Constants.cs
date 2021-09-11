namespace Autobrawl.Engine;

public static class Constants
{
    public static List<Card> AllCards = new();

    public static List<Champion> AllChampions
    {
        get
        {
            List<Champion> champions = new()
            {
                new Champion { ID = 1, Name = $"Mr. {(Keywords)1}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 2, Name = $"Mr. {(Keywords)2}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 3, Name = $"Mr. {(Keywords)3}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 4, Name = $"Mr. {(Keywords)4}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 5, Name = $"Mr. {(Keywords)5}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 6, Name = $"Mr. {(Keywords)6}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 7, Name = $"Mr. {(Keywords)7}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 8, Name = $"Mr. {(Keywords)8}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 9, Name = $"Mr. {(Keywords)9}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 10, Name = $"Mr. {(Keywords)10}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 11, Name = $"Mr. {(Aspect)0}", AbilityDescription = "", Aspect = Aspect.Normal },
                new Champion { ID = 12, Name = $"Mr. {(Aspect)1}", AbilityDescription = "", Aspect = Aspect.Fire },
                new Champion { ID = 13, Name = $"Mr. {(Aspect)2}", AbilityDescription = "", Aspect = Aspect.Water },
                new Champion { ID = 14, Name = $"Mr. {(Aspect)3}", AbilityDescription = "", Aspect = Aspect.Earth },
                new Champion { ID = 15, Name = $"Mr. {(Aspect)4}", AbilityDescription = "", Aspect = Aspect.Air },
                new Champion { ID = 16, Name = $"Mr. {(Aspect)5}", AbilityDescription = "", Aspect = Aspect.Death },
                new Champion { ID = 17, Name = $"Mr. {(Aspect)6}", AbilityDescription = "", Aspect = Aspect.Shadow },
                new Champion { ID = 18, Name = $"Mr. {(Aspect)7}", AbilityDescription = "", Aspect = Aspect.Light },
                new Champion { ID = 19, Name = $"Mr. {(Aspect)8}", AbilityDescription = "", Aspect = Aspect.Nature },
                new Champion { ID = 20, Name = $"Mr. {(Aspect)9}", AbilityDescription = "", Aspect = Aspect.Psychic }
            };

            return champions;
        }
    }

    /// <summary>
    /// Aspect: Normal (0)
    /// </summary>
    public static List<Card> AllNormalCards
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

    /// <summary>
    /// Aspect: Fire (1)
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
                new Card { ID = 1121, Aspect = Aspect.Fire, Level = Level.Two, Name = "", BaseAttack = 3, BaseHealth = 3, Keywords = Keywords.HotStreak, Text = $"{Keywords.HotStreak}: Give another {Aspect.Fire} unit +1/+1 "},
                new Card { ID = 1122, Aspect = Aspect.Fire, Level = Level.Two, Name = "", BaseAttack = 2, BaseHealth = 4, Keywords = Keywords.HotStreak & Keywords.Distract, Text = $"{Keywords.HotStreak}: Gain 1 health "},
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

                //Level 6
                new Card { ID = 1161, Aspect = Aspect.Fire, Level = Level.Six, Name = "", BaseAttack = 6, BaseHealth = 12, Keywords = Keywords.HotStreak & Keywords.Survivor, Text = $"{Keywords.HotStreak}: Gain stats equal to half the unit's stats. {Keywords.Survivor}: Your {Aspect.Fire} units cost 1 less during your next draft" },
                new Card { ID = 1162, Aspect = Aspect.Fire, Level = Level.Six, Name = "", BaseAttack = 8, BaseHealth = 8, Keywords = Keywords.HotStreak, Text = $"{Keywords.HotStreak}: Give a random friendly unit stats equal to the unit's stats" },
                new Card { ID = 1163, Aspect = Aspect.Fire, Level = Level.Six, Name = "", BaseAttack = 10, BaseHealth = 5, Keywords = Keywords.Neutralize & Keywords.Fervor & Keywords.Inspire, Text = $"{Keywords.Inspire}: Attack immediately" }
            };
            return cards;
        }
    }
}