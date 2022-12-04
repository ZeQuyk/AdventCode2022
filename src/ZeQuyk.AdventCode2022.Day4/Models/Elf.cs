using System.Collections.Generic;
using System.Linq;

namespace ZeQuyk.AdventCode2022.Day4.Models
{
    public class Elf
    {
        public Elf(string values)
        {
            var splittedValues = values.Split('-').Select(value => int.Parse(value));
            var firstValue = splittedValues.First();
            AssignedSections = Enumerable.Range(firstValue, splittedValues.Last() - firstValue + 1).ToList();
        }

        public List<int> AssignedSections { get; private set; }

        public bool ClearsAssignedSections(Elf otherElf) => !otherElf.AssignedSections.Except(AssignedSections).Any();
            
    }
}
