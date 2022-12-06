using System.Linq;
using System.Text.RegularExpressions;

namespace ZeQuyk.AdventCode2022.Day5.Models
{
    public class Move
    {
        public Move(string move)
        {
            var result = Regex.Matches(move, @"\d+");
            CratesAmount = int.Parse(result[0].Value);
            FromId = int.Parse(result[1].Value);
            TargetId = int.Parse(result[2].Value);
        }

        public int CratesAmount { get; set; }

        public int FromId { get; set; }

        public int TargetId { get; set; }
    }
}
