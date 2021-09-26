namespace Autobrawl.Model.Objects
{
    public class Spell
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string EffectDescription { get; set; }
        public Aspect Aspect { get; set; } //TODO: Should be nullable? Or is it fine to have Aspect.Normal for non-aspect spells?
    }
}