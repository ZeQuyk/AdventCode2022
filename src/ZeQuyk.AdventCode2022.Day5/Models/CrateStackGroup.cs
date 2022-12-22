using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZeQuyk.AdventCode2022.Day5.Models
{
    public class CrateStackGroup<T>
        where T : CratesStack9000, new()
    {
        private const int CrateSpace = 3;

        public CrateStackGroup(string input)
        {
            var lineGroups = input.Split($"{Environment.NewLine}{Environment.NewLine}");
            var stacks = lineGroups.First();
            Stacks = ParseStacks(stacks);

            var moveLines = lineGroups.Last().Split(Environment.NewLine);
            Moves = moveLines.Select(x => new Move(x)).ToList();
        }

        public List<Move> Moves { get; set; }

        public List<T> Stacks { get; set; }

        public void ApplyMoves()
        {
            foreach (var move in Moves)
            {
                var stack = Stacks.First(x => x.Id == move.FromId);
                var movingCrates = stack.Remove(move.CratesAmount);
                var target = Stacks.First(x => x.Id == move.TargetId);
                target.PushMultiple(movingCrates);
            }
        }

        public string GetTopLevelCrates()
        {
            var stringBuilder = new StringBuilder();
            foreach (var crates in Stacks)
            {
                stringBuilder.Append($"{crates.Crates.Peek()}");
            }

            return stringBuilder.ToString();
        }

        private static List<T> ParseStacks(string stacks)
        {
            var stackLines = stacks.Split(Environment.NewLine).ToList();
            var stackHeight = stackLines.Count;
            var numberOfCrates = stackLines.First().Chunk(CrateSpace + 1).Count();
            var cratesGroups = stackLines.Select(x => new List<string>()).ToList();
            foreach (var stackLine in stackLines)
            {
                var crates = stackLine.Chunk(CrateSpace + 1).ToList();
                foreach (var crate in crates)
                {
                    var crateAsString = new string(crate).Trim();
                    if (string.IsNullOrEmpty(crateAsString))
                    {
                        continue;
                    }

                    cratesGroups[crates.IndexOf(crate)].Add(crateAsString);
                }
            }

            return cratesGroups.Select(x => new T().Initialize<T>(x)).ToList();
        }
    }
}
