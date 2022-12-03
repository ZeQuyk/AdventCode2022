namespace ZeQuyk.AdventCode2022.Day3
{
    public static class CharExtensions
    {
        public static bool IsUppercase(this char character)
            => character >= 'A' && character <= 'Z';
    }
}
