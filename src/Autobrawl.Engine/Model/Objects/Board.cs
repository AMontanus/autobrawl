namespace Autobrawl.Engine.Model;
public class Board
{
    [Key, Required]
    public Guid ID {  get; } = Guid.NewGuid();

    public int MaxUnits {  get; set; }

    public List<Unit> Units {  get; set; }
}