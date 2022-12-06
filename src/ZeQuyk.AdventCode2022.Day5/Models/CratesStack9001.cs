using System.Collections.Generic;

namespace ZeQuyk.AdventCode2022.Day5.Models
{
    public class CratesStack9001 : CratesStack9000
    {
        private const int RemoveByBatchesOf = 3;

        public CratesStack9001()
        {
        }

        public override List<char> Remove(int amount)
        {
            var result = base.Remove(amount);
            result.Reverse();

            return result;
        }
    }
}
