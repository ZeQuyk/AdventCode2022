using System;
using System.Collections.Generic;
using Advent2022.Core;
using ZeQuyk.AdventCode2022.Day3.Models;

namespace ZeQuyk.AdventCode2022.Day3
{
    public class Puzzle2 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var sum = 0;
            for (int i = 0; i < lines.Length; i += 3)
            {
                var elfGroup = new ElfGroup(new List<string>
                {
                    lines[i],
                    lines[i + 1],
                    lines[i + 2],
                });
                sum += elfGroup.GetBadge();
            }

            return sum.ToString();
        }
    }
}
