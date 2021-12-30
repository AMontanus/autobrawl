namespace Autobrawl.Engine.Model;

public static partial class Constants
{
    //Level 1
    public static readonly Card Shadow1611 = new() { ID = 1611, Aspect = Aspect.Shadow, Level = Level.One, Name = "", BaseAttack = 1, BaseHealth = 2, Keywords = Keywords.Blend & Keywords.Inspire, Text = $"{Keywords.Inspire}: {Keywords.Blend}: Deal 1 damage to a random enemy unit" };
    public static readonly Card Shadow1612 = new() { ID = 1612, Aspect = Aspect.Shadow, Level = Level.One, Name = "", BaseAttack = 1, BaseHealth = 3, Keywords = Keywords.None, Text = $"" };



    /// <summary>
    /// Aspect: Shadow (6)
    /// </summary>
    public static List<Card> AllShadowCards
    {
        get
        {
            return (List<Card>)(new()
            {

            });
        }
    }
}