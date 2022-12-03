using System.Linq;
using Advent2022.Core;

namespace ZeQuyk.AdventCode2022.Day2
{
    public class Puzzle1 : PuzzleBase
    {
        protected override string Solve(string input)
        {
            var lines = input.Split("\r\n");
            var points = 0;

            foreach (var line in lines)
            {
                var (opponent, me) = ParseLine(line);
                if (me.IsWinning(opponent))
                {
                    points += 6;
                }
                else if (me == opponent)
                {
                    points += 3;
                }

                points += me.GetPoints();
            }

            return points.ToString();
        }

        private static (HandShapes opponent, HandShapes me) ParseLine(string line)
        {
            var opponent = line.First() switch
            {
                'A' => HandShapes.Rock,
                'B' => HandShapes.Paper,
                'C' => HandShapes.Scissors,
                _ => throw new System.NotImplementedException(),
            };
            var me = line.Last() switch
            {
                'X' => HandShapes.Rock,
                'Y' => HandShapes.Paper,
                'Z' => HandShapes.Scissors,
                _ => throw new System.NotImplementedException(),
            };

            return (opponent, me);
        }
    }
}
