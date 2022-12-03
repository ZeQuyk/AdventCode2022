using System;
using System.Linq;

namespace ZeQuyk.AdventCode2022.Day2
{
    public class Puzzle2 : Day2PuzzleBase
    {
        protected override string Solve(string input)
        {
            var lines = input.Split(Environment.NewLine);
            var points = 0;

            foreach (var line in lines)
            {
                var (opponent, expectedResult) = ParseLine(line);
                var me = expectedResult.GetExpectedHandShape(opponent);
                points += CalculatePoints(opponent, me);
            }

            return points.ToString();
        }

        private (HandShapes opponent, ExpectedResults expectedResult) ParseLine(string line)
        {
            var opponent = ParseOpponent(line);

            var expectedResult = line.Last() switch
            {
                'X' => ExpectedResults.Lose,
                'Y' => ExpectedResults.Draw,
                'Z' => ExpectedResults.Win,
                _ => throw new NotImplementedException(),
            };

            return (opponent, expectedResult);
        }
    }
}
