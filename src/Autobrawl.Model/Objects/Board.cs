namespace Autobrawl.Model.Objects;
public class Board
{
    public Board()
    {
        ID = Guid.NewGuid();
    }

    [Required]
    [Key]
    public Guid ID {  get; set; }

    public int MaxUnits {  get; set; }

    public List<Unit> Units {  get; set; }
}