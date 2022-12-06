using System.Collections.Generic;
using System.Linq;

namespace ZeQuyk.AdventCode2022.Day5.Models
{
    public class CratesStack9000
    {
        public CratesStack9000()
        {
        }

        public int Id { get; set; }

        public Stack<char> Crates { get; private set; }

        public T Initialize<T>(IEnumerable<string> values)
            where T : CratesStack9000
        {
            Id = int.Parse(values.Last());
            var stack = values.Where(x => x != values.Last() && !string.IsNullOrWhiteSpace(x)).Select(x => x[1]).ToList();
            stack.Reverse();
            Crates = new Stack<char>(stack);

            return (T)this;
        }

        public virtual List<char> Remove(int amount)
        {
            var removed = new List<char>(amount);
            for (int i = 0; i < amount; i++)
            {
                removed.Add(Crates.Pop());
            }

            return removed;
        }

        public void PushMultiple(List<char> crates)
        {
            foreach (var crate in crates)
            {
                Crates.Push(crate);
            }
        }
    }
}
