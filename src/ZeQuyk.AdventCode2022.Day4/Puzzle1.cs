using System.Linq;

namespace ZeQuyk.AdventCode2022.Day4
{
    public class Puzzle1 : Day4PuzzleBase
    {
        protected override string Solve(string input)
        {
            var pairs = ParsePairs(input);

            return pairs.Where(pair => pair.HaveSameSections()).Count().ToString();
        }
    }
}
