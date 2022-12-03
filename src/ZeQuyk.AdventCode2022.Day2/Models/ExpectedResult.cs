namespace ZeQuyk.AdventCode2022.Day2.Models
{
    public enum ExpectedResults
    {
        Win,
        Draw,
        Lose
    }

    public static class ExpectedResultsExtensions
    {
        public static HandShapes GetExpectedHandShape(this ExpectedResults expectedResult, HandShapes opponent)
        {
            if (expectedResult == ExpectedResults.Draw)
            {
                return opponent;
            }

            var expectWin = expectedResult == ExpectedResults.Win;
            return opponent switch
            {
                HandShapes.Rock => expectWin ? HandShapes.Paper : HandShapes.Scissors,
                HandShapes.Paper => expectWin ? HandShapes.Scissors : HandShapes.Rock,
                HandShapes.Scissors => expectWin ? HandShapes.Rock : HandShapes.Paper,
                _ => throw new System.NotImplementedException(),
            };
        }
    }
}
