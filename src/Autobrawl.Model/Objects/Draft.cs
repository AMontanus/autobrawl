namespace Autobrawl.Model;
public class Draft
{
    private static readonly int _baseDraftSeconds = 60;

    public Draft()
    {
        DraftTime = _baseDraftSeconds;
    }

    public static int MaxDraftTime { get; } = 120;
    public static int AddedPerRound { get; } = 15;

    [Required]
    public int ID { get; set; }

    [Required]
    public int DraftTime {  get; set; }
}