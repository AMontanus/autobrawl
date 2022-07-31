namespace Autobrawl.Engine.Model;

public static partial class Constants
{
    public static List<Champion> AllChampions => new()
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
                new Champion { ID = 18, Name = $"Mr. {(Aspect)7}", AbilityDescription = "", Aspect = Aspect.Lightning },
                new Champion { ID = 19, Name = $"Mr. {(Aspect)8}", AbilityDescription = "", Aspect = Aspect.Nature },
                new Champion { ID = 20, Name = $"Mr. {(Aspect)9}", AbilityDescription = "", Aspect = Aspect.Psychic }
            };
}