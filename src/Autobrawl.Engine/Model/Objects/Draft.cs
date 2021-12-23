namespace Autobrawl.Engine.Model;
public class Draft
{
    private const int BASE_DRAFT_TIME = 60;
    private const int MAX_DRAFT_TIME = 120;
    public const int ADDED_PER_ROUND = 15;

    [Key, Required]
    public Guid ID { get; } = Guid.NewGuid();

    public int DraftTime { get; private set; } = BASE_DRAFT_TIME;

    public void IncrementDraftTime()
        => DraftTime = Math.Min(MAX_DRAFT_TIME, DraftTime + ADDED_PER_ROUND);
}