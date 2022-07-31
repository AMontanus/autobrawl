using Microsoft.Extensions.Options;

namespace Autobrawl.Engine.Config;

public class DeckOptions
{
    public const string Deck = "Deck";
    
    public int CopiesLvlOne { get; set; }
    public int CopiesLvlTwo { get; set; }
    public int CopiesLvlThree { get; set; }
    public int CopiesLvlFour { get; set; }
    public int CopiesLvlFive { get; set; }
    public int CopiesLvlSix { get; set; }
}