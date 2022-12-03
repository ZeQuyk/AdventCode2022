using System;
using System.Linq;
using Advent2022.Core;
using ZeQuyk.AdventCode2022.Day3.Models;

namespace ZeQuyk.AdventCode2022.Day3
{
    public class Puzzle1 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var sum = lines.Select(line => new RuckSack(line)).Sum(ruckSack => ruckSack.GetPriority());

            return sum.ToString();
        }
    }
}
