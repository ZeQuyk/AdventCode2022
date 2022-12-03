using System;
using System.Linq;
using Advent2022.Core;

namespace ZeQuyk.AdventCode2022.Day3
{
    public class Puzzle1 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var sum = lines.Select(x => new RuckSack(x)).Sum(x => x.GetPriority());

            return sum.ToString();
        }
    }
}
