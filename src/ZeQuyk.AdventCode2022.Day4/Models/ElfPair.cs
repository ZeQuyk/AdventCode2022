using System.Linq;

namespace ZeQuyk.AdventCode2022.Day4.Models
{
    public class ElfPair
    {
        public ElfPair(string input)
        {
            var elves = input.Split(',');
            Elf1 = new Elf(elves.First());
            Elf2 = new Elf(elves.Last());
        }

        public Elf Elf1 { get; set; }

        public Elf Elf2 { get; set; }

        public bool HaveSameSections() => Elf1.ClearsAssignedSections(Elf2) || Elf2.ClearsAssignedSections(Elf1);

        public bool HaveAnyCommonSections() => Elf1.AssignedSections.Any(x => Elf2.AssignedSections.Contains(x));
        
    }
}
