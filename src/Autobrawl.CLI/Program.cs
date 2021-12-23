var match = new MatchManager();

var players = new List<Player>() { new(), new(), new(), new(), new(), new() };

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Match started at: {match.Match.Start}");
foreach (Aspect aspect in match.AvailableAspects)
    Console.WriteLine($"{aspect}");

foreach (var player in players)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Player no: {player.PlayerNo}");
    Console.ForegroundColor = ConsoleColor.Red;
}
Console.ResetColor();

match.EndMatch();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Match ended at: {match.Match.End}");
Console.ReadKey();