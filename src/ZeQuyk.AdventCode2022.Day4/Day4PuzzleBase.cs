using System;
using System.Collections.Generic;
using System.Linq;
using Advent2022.Core;
using ZeQuyk.AdventCode2022.Day4.Models;

namespace ZeQuyk.AdventCode2022.Day4
{
    public abstract class Day4PuzzleBase : PuzzleBase
    {
        protected static List<ElfPair> ParsePairs(string input) => input.Split(Environment.NewLine).Select(line => new ElfPair(line)).ToList();
    }
}
