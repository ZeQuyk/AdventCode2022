using System.Linq;

namespace ZeQuyk.AdventCode2022.Day3
{
    public class RuckSack : PriorityCalculatorBase
    {
        public RuckSack(string input)
        {
            Value = input;
        }

        public string Value { get; private set; }

        protected int Length => Value.Length;

        protected string Compartment1 => Value.Substring(0, Length / 2);

        protected string Compartment2 => Value.Substring(Length / 2);

        protected char Department => Compartment1.FirstOrDefault(x => Compartment2.Contains(x));

        public int GetPriority() => CalculatePriority(Department);
    }
}
