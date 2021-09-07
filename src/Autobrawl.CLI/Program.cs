using Autobrawl.Model.Objects;

var match = new MatchManager();
 
var players = new List<Player>() { new(), new(), new(), new(), new(), new() };
var playerState = new PlayerStateManager(players);
players = playerState.Players;
players = ChampionManager.AllocateChampionChoices(players);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Match started at: {match.Match.Start}");

foreach(var player in players)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Player no: {player.PlayerNo}");
    Console.ForegroundColor = ConsoleColor.Red;
    foreach (var champ in player.ChampionChoices)
        Console.WriteLine($"ID: {champ.ID}, Name: {champ.Name}");
}
Console.ResetColor();


match.EndMatch();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Match ended at: {match.Match.End}");
Console.ReadKey(); 