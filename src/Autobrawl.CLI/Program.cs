var draft = new DraftManager();

for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Round {i} - Draft time: {draft.Draft.DraftTime}");
    draft.IncrementDraftTime();
}