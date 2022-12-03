using System.Collections.Generic;
using System.Linq;

namespace ZeQuyk.AdventCode2022.Day3.Models
{
    public class ElfGroup : PriorityCalculatorBase
    {
        public ElfGroup(IEnumerable<string> input)
        {
            RuckSacks = input.Select(x => new RuckSack(x));
        }

        public IEnumerable<RuckSack> RuckSacks { get; private set; }

        public int GetBadge()
        {
            foreach (var item in RuckSacks.First().Value)
            {
                if (RuckSacks.All(x => x.Value.Contains(item)))
                {
                    return CalculatePriority(item);
                }
            }

            return default;
        }
    }
}
