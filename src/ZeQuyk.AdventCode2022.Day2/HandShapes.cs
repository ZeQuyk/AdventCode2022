namespace ZeQuyk.AdventCode2022.Day2
{
    public enum HandShapes
    {
        Rock,
        Paper,
        Scissors
    }

    public static class HandShapesExtensions
    {
        public static bool IsWinning(this HandShapes me, HandShapes opponent)
        {
            return opponent switch
            {
                HandShapes.Rock => me == HandShapes.Paper,
                HandShapes.Paper => me == HandShapes.Scissors,
                HandShapes.Scissors => me == HandShapes.Rock,
                _ => false,
            };
        }

        public static int GetPoints(this HandShapes me)
        {
            return me switch
            {
                HandShapes.Rock => 1,
                HandShapes.Paper => 2,
                HandShapes.Scissors => 3,
                _ => throw new System.NotImplementedException(),
            };
        }
    }
}
