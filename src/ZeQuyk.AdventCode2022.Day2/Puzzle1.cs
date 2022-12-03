using System;
using System.Linq;

namespace ZeQuyk.AdventCode2022.Day2
{
    public class Puzzle1 : Day2PuzzleBase
    {
        protected override string Solve(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var points = 0;

            foreach (var line in lines)
            {
                var (opponent, me) = ParseLine(line);
                points += CalculatePoints(opponent, me);
            }

            return points.ToString();
        }

        private static (HandShapes opponent, HandShapes me) ParseLine(string line)
        {
            var opponent = ParseOpponent(line);
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
