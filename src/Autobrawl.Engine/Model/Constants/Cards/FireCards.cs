namespace Autobrawl.Engine.Model;

public static partial class CardExtensions
{
    //Level 1
    public static readonly Card Fire1111 = new() { ID = 1111, Aspect = Aspect.Fire, Level = 1, Name = "", BaseAttack = 1, BaseHealth = 4, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Your next refresh costs 0" };
    public static readonly Card Fire1112 = new() { ID = 1112, Aspect = Aspect.Fire, Level = 1, Name = "", BaseAttack = 3, BaseHealth = 2, Keywords = Keywords.Overkill, Text = $"{Keywords.Overkill}: Permanently gain +1/+1" };
    public static readonly Card Fire1113 = new() { ID = 1113, Aspect = Aspect.Fire, Level = 1, Name = "", BaseAttack = 2, BaseHealth = 2, Keywords = Keywords.Survivor, Text = $"{Keywords.Survivor}: Reduce the cost of leveling up by 1" };

    //Level 2
    public static readonly Card Fire1121 = new() { ID = 1121, Aspect = Aspect.Fire, Level = 2, Name = "", BaseAttack = 3, BaseHealth = 3, Keywords = Keywords.HotStreak, Text = $"{Keywords.HotStreak}: Give another {Aspect.Fire} unit +1/+1 " };
    public static readonly Card Fire1122 = new() { ID = 1122, Aspect = Aspect.Fire, Level = 2, Name = "", BaseAttack = 2, BaseHealth = 4, Keywords = Keywords.HotStreak & Keywords.Distract, Text = $"{Keywords.HotStreak}: Gain 1 health " };
    public static readonly Card Fire1123 = new() { ID = 1123, Aspect = Aspect.Fire, Level = 2, Name = "", BaseAttack = 2, BaseHealth = 3, Keywords = Keywords.EndOfTurn, Text = $"{Keywords.EndOfTurn}: Your next {Aspect.Fire} unit costs 1 less" };

    //Level 3
    public static readonly Card Fire1131 = new() { ID = 1131, Aspect = Aspect.Fire, Level = 3, Name = "", BaseAttack = 4, BaseHealth = 2, Keywords = Keywords.Rebuff & Keywords.Fervor, Text = $"" };
    public static readonly Card Fire1132 = new() { ID = 1132, Aspect = Aspect.Fire, Level = 3, Name = "", BaseAttack = 3, BaseHealth = 3, Keywords = Keywords.Invoke, Text = $"{Keywords.Invoke}: Give another {Aspect.Fire} unit stats equal to your level" };
    public static readonly Card Fire1133 = new() { ID = 1133, Aspect = Aspect.Fire, Level = 3, Name = "", BaseAttack = 1, BaseHealth = 5, Keywords = Keywords.Survivor, Text = $"{Keywords.Survivor}: Add a random level 3 or lower {Aspect.Fire} card to your hand" };

    //Level 4
    public static readonly Card Fire1141 = new() { ID = 1141, Aspect = Aspect.Fire, Level = 4, Name = "", BaseAttack = 5, BaseHealth = 4, Keywords = Keywords.HotStreak, Text = $"{Keywords.HotStreak}: Your next refresh costs 0" };
    public static readonly Card Fire1142 = new() { ID = 1142, Aspect = Aspect.Fire, Level = 4, Name = "", BaseAttack = 4, BaseHealth = 6, Keywords = Keywords.Survivor & Keywords.LastStand, Text = $"{Keywords.Survivor}: Permanently give your {Aspect.Fire} units +3/+3" };
    public static readonly Card Fire1143 = new() { ID = 1143, Aspect = Aspect.Fire, Level = 4, Name = "", BaseAttack = 7, BaseHealth = 5, Keywords = Keywords.Cleave & Keywords.Overkill, Text = $"{Keywords.Overkill}: Permanently gain +2/+1" };

    //Level 5
    public static readonly Card Fire1151 = new() { ID = 1151, Aspect = Aspect.Fire, Level = 5, Name = "", BaseAttack = 4, BaseHealth = 4, Keywords = Keywords.HotStreak, Text = $"{Keywords.HotStreak}: All {Aspect.Fire} units permanently gain +1/+1" };
    public static readonly Card Fire1152 = new() { ID = 1152, Aspect = Aspect.Fire, Level = 5, Name = "", BaseAttack = 6, BaseHealth = 6, Keywords = Keywords.CurtainCall & Keywords.Distract, Text = $"{Keywords.CurtainCall}: Summon a random {Aspect.Fire} unit and add it to your hand" };
    public static readonly Card Fire1153 = new() { ID = 1153, Aspect = Aspect.Fire, Level = 5, Name = "", BaseAttack = 4, BaseHealth = 4, Keywords = Keywords.LastStand & Keywords.Rebuff & Keywords.Inspire, Text = $"{Keywords.Inspire}: Give a random friendly unit {Keywords.Rebuff}" };

    //Level 6
    public static readonly Card Fire1161 = new() { ID = 1161, Aspect = Aspect.Fire, Level = 6, Name = "", BaseAttack = 6, BaseHealth = 12, Keywords = Keywords.HotStreak & Keywords.Survivor, Text = $"{Keywords.HotStreak}: Gain stats equal to half the unit's stats. {Keywords.Survivor}: Your {Aspect.Fire} units cost 1 less during your next draft" };
    public static readonly Card Fire1162 = new() { ID = 1162, Aspect = Aspect.Fire, Level = 6, Name = "", BaseAttack = 8, BaseHealth = 8, Keywords = Keywords.HotStreak, Text = $"{Keywords.HotStreak}: Give a random friendly unit stats equal to the unit's stats" };
    public static readonly Card Fire1163 = new() { ID = 1163, Aspect = Aspect.Fire, Level = 6, Name = "", BaseAttack = 10, BaseHealth = 5, Keywords = Keywords.Neutralize & Keywords.Fervor & Keywords.Inspire, Text = $"{Keywords.Inspire}: Attack immediately" };

    /// <summary>
    /// Aspect: Fire (1)
    /// Built around playing more and more Fire cards
    /// </summary>
    public static List<Card> AllFireCards()
    {
        return new()
        {
            Fire1111,
            Fire1112,
            Fire1113,
            Fire1121,
            Fire1122,
            Fire1123,
            Fire1131,
            Fire1132,
            Fire1133,
            Fire1141,
            Fire1142,
            Fire1143,
            Fire1151,
            Fire1152,
            Fire1153,
            Fire1161,
            Fire1162,
            Fire1163,
        };
    }
}