namespace ZeQuyk.AdventCode2022.Day3
{
    public abstract class PriorityCalculatorBase
    {
        private const int LowerCaseSubstraction = 96;
        private const int UpperCaseSubstraction = 38;

        protected int CalculatePriority(char character)
        {
            var substraction = char.IsUpper(character) ? UpperCaseSubstraction : LowerCaseSubstraction;

            return character - substraction;
        }
    }
}
