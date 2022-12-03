using System.Collections.Generic;
using System.Linq;
using Advent2022.Core;

namespace ZeQuyk.AdventCode2022.Day1
{
    public class Puzzle2 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var caloriesLinesByElf = input.Split("\r\n\r\n").ToList();
            var sums = new List<int>();
            foreach(var caloriesLines in caloriesLinesByElf)
            {
                sums.Add(caloriesLines.Split("\r\n").Sum(x => int.Parse(x)));
            }

            return sums.OrderByDescending(x => x).Take(3).Sum().ToString();
        }
    }
}
