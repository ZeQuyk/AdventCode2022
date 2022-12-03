using System.Linq;
using Advent2022.Core;
using ZeQuyk.AdventCode2022.Day2.Models;

namespace ZeQuyk.AdventCode2022.Day2
{
    public abstract class Day2PuzzleBase : PuzzleBase
    {
        protected const int WinPoints = 6;
        protected const int DrawPoints = 3;

        protected static HandShapes ParseOpponent(string line)
        {
           return line.First() switch
            {
                'A' => HandShapes.Rock,
                'B' => HandShapes.Paper,
                'C' => HandShapes.Scissors,
                _ => throw new System.NotImplementedException(),
            };
        }

        protected static int CalculatePoints(HandShapes opponent, HandShapes me)
        {
            var points = 0;
            if (me.IsWinning(opponent))
            {
                points += WinPoints;
            }
            else if (me == opponent)
            {
                points += DrawPoints;
            }

            points += me.GetPoints();

            return points;
        }
    }
}
