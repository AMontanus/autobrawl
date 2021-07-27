namespace Autobrawl.Model
{
    public class Aspect
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Card> Cards { get; set; }
    }
}
