using Advent2022.Core;
using ZeQuyk.AdventCode2022.Day5.Models;

namespace ZeQuyk.AdventCode2022.Day5
{
    public class Puzzle1 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var crateStacksGroup = new CrateStackGroup<CratesStack9000>(input);
            crateStacksGroup.ApplyMoves();

            return crateStacksGroup.GetTopLevelCrates();
        }
    }
}
