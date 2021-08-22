namespace Autobrawl.Model;
public class Draft
{
    public Draft()
    {
        _round = _firstRound;
        _draftTime = _baseDraftSeconds;
    }

    private static readonly int _firstRound = 1;
    private static readonly int _baseDraftSeconds = 60;
    private static readonly int _maxDraftSeconds = 120;
    private static readonly int _addedSecsPerRound = 15;
    private int _draftTime;
    private int _round;

    [Required]
    public int ID { get; set; }

    [Required]
    public int Round
    {
        get => _round;
        set
        {
            _round++;
        }
    }

    [Required]
    public int DraftTimeInSeconds
    {
        get => _draftTime;
        set
        {
            int roundTime = _baseDraftSeconds + (Round * _addedSecsPerRound);
            _draftTime = (roundTime <= _maxDraftSeconds ? roundTime : _maxDraftSeconds);
        }
    }
}