namespace Autobrawl.Model;
public class Draft
{
    private static readonly int _baseDraftSeconds = 60;
    public static int MaxDraftTime { get; } = 120;
    public static int AddedPerRound { get; } = 15;

    public Draft()
    {
        DraftTime = _baseDraftSeconds;
    }

    [Required]
    public int ID { get; set; }

    [Required]
    public int DraftTime {  get; set; }
}