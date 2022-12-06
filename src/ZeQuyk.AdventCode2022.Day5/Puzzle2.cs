using Advent2022.Core;
using ZeQuyk.AdventCode2022.Day5.Models;

namespace ZeQuyk.AdventCode2022.Day5
{
    public class Puzzle2 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var crateStacksGroup = new CrateStackGroup<CratesStack9001>(input);
            crateStacksGroup.ApplyMoves();

            return crateStacksGroup.GetTopLevelCrates();
        }
    }
}
