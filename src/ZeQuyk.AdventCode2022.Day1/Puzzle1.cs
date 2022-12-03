using Advent2022.Core;

namespace ZeQuyk.AdventCode2022.Day1
{
    public class Puzzle1 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var caloriesLinesByElf = input.Split("\r\n\r\n").ToList();
            var maxCalories = 0;
            foreach (var calorieLines in caloriesLinesByElf)
            {
                var sum = calorieLines.Split("\r\n").Sum(x => int.Parse(x));
                if (sum > maxCalories)
                {
                    maxCalories = sum;
                }
            }

            return maxCalories.ToString();
        }
    }
}
