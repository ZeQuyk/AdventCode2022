using System;
using System.Linq;

namespace ZeQuyk.AdventCode2022.Day3
{
    public class RuckSack
    {
        private const int LowerCaseSubstraction = 96;
        private const int UpperCaseSubstraction = 38;

        public RuckSack(string input)
        {
            Item1 = input.Substring(0, input.Length / 2);
            Item2 = input.Substring(input.Length / 2);
        }

        protected string Item1 { get; set; }

        protected string Item2 { get; set; }

        protected char Department => Item1.FirstOrDefault(x => Item2.Contains(x));

        public int GetPriority()
        {
            var substraction = Department.IsUppercase() ? UpperCaseSubstraction : LowerCaseSubstraction;

            return Department - substraction;
        }
    }
}
