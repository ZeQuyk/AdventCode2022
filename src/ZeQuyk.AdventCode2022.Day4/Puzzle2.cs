using System.Linq;

namespace ZeQuyk.AdventCode2022.Day4
{
    public class Puzzle2 : Day4PuzzleBase
    {
        protected override string Solve(string input)
        {
            var pairs = ParsePairs(input);

            return pairs.Where(pair => pair.HaveAnyCommonSections()).Count().ToString();
        }
    }
}
