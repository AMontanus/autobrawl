using Autobrawl.Engine.Mechanics;
using Autobrawl.Model;

namespace Autobrawl.CLI;
class Program
{
    static void Main(string[] args)
    {
        var match = new Match();
        var phaseManager = new PhaseManager();


        match.EndMatch();

        Console.WriteLine("Hello World!");
    }
}