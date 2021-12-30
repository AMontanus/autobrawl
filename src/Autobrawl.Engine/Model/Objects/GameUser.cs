namespace Autobrawl.Engine.Model;
public class GameUser
{
    [Key, Required]
    public Guid ID { get; } = Guid.NewGuid();

    [Required, EmailAddress]
    public string Username { get; set; }

    public bool Verified { get; set; }
}