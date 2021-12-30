namespace Autobrawl.Engine.Model;

public static partial class Constants
{
    public static readonly Spell Snowball = new() { ID = 5001, Name = "Snowball", EffectDescription = $"Give a friendly {Aspect.Water} unit +2/+2", Aspect = Aspect.Water };
    public static readonly Spell ManaDroplet = new() { ID = 5002, Name = "Mana Droplet", EffectDescription = "Gain 1 mana", Aspect = Aspect.Normal };

    public static List<Spell> AllSpells
    {
        get
        {
            return (List<Spell>)(new()
            {
                Snowball,
                ManaDroplet
            });
        }
    }
}
