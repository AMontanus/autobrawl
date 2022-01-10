var beginning = DateTime.Now;
var cardState = CardStateManager.Instance;
for(int i = 0; i < 100; i++)
{
    var instanceStart = DateTime.Now;
    _ = cardState.Deck.TryGetNonEnumeratedCount<Card>(out var countBefore);
    Console.WriteLine($"Card count before: {countBefore}");

    var cards = cardState.Draw(3);
    _ = cardState.Deck.TryGetNonEnumeratedCount<Card>(out var countDuring);
    Console.WriteLine($"Card count during: {countDuring}");

    foreach (var card in cards)
        Console.WriteLine($"{card}");
    cardState.Return(cards);

    _ = cardState.Deck.TryGetNonEnumeratedCount<Card>(out var countAfter);
    Console.WriteLine($"Card count after: {countAfter}");
    var instanceEnd = DateTime.Now;

    Console.WriteLine($"Round-trip took {instanceEnd.Millisecond - instanceStart.Millisecond} ms");
}

var final = DateTime.Now;

Console.WriteLine($"Total time in seconds: {final.Second - beginning.Second}");