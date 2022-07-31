using Autobrawl.Engine.Config;
using Autobrawl.Engine.Mechanics;
using Autobrawl.Engine.Model;
using Microsoft.Extensions.Options;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autobrawl.Tests;

[TestFixture]
internal class DeckManagerTests
{
    private static readonly DeckOptions options = new() { CopiesLvlOne = 18, CopiesLvlTwo = 16, CopiesLvlThree = 14, CopiesLvlFour = 12, CopiesLvlFive = 10, CopiesLvlSix = 8 };
    private readonly DeckManager _deckManager = new(Options.Create(options));
    private readonly List<Aspect> _aspects = AspectFunctions.Rummage();


    [SetUp]
    public async Task Setup()
    {
        await _deckManager.FillBag(_aspects);
    }

    //Test that the card state manager can fill the bag with the correct number of cards
    [Test]
    public void FillBag_CardsAreAdded()
    {
    }

    //Test that Draw pulls a card from the deck and reduces deck size by 1
    [Test]
    public void Draw_CardIsRemovedFromDeck()
    {
    }
}