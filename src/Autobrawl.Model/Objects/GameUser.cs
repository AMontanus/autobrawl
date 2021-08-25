namespace Autobrawl.Model.Objects;
public class GameUser
{
    [Required]
    [Key]
    public Guid ID {  get; set; }

    [Required]
    [EmailAddress]
    public string Username {  get; set; }

    public bool Verified {  get; set; }
}
