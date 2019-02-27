using System;
using System.Linq;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        const int Alphabetsize = 26;

        return input
            .ToLower()
            .Distinct()
            .Count(char.IsLetter) == Alphabetsize;
    }
}
