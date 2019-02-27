using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length > secondStrand.Length)
            throw new ArgumentException(string.Format("first strand {0} is too many", firstStrand.Length));

        if (secondStrand.Length > firstStrand.Length)
            throw new ArgumentException(string.Format("Second Strand {0} is too many", secondStrand.Length));

        return firstStrand
               .Zip(secondStrand, Tuple.Create)
               .Aggregate(0, (total, pair) =>
               pair.Item1 == pair.Item2 ? total : total + 1
               );
    }
}