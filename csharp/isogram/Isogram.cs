using System;
using System.Linq;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        return word
                .Where(char.IsLetter)
                .Select(char.ToLower)
                .GroupBy(c => c)
                .FirstOrDefault(g => g.Count() > 1) == null;
    }
}
