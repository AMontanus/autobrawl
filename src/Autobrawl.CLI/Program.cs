var match = new MatchManager();

Console.WriteLine($"Match started at: {match.Match.Start}");
for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Round {i} - Draft time: {match.DraftManager.Draft.DraftTime}");
    Console.WriteLine($"Current phase: {match.PhaseManager.CurrentPhase}");
    match.PhaseManager.ChangePhase();

    if (match.PhaseManager.CurrentPhase == Phase.Draft)
        match.DraftManager.IncrementDraftTime();
}
match.EndMatch();
Console.WriteLine($"Match ended at: {match.Match.End}");