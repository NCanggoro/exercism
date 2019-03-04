using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if (firstStrand.Length > secondStrand.Length)
            throw new ArgumentException($"first strand {firstStrand.Length} is longer second strand");

        if (secondStrand.Length > firstStrand.Length)
            throw new ArgumentException($"Second Strand {secondStrand.Length} is longer than first strand");

        return firstStrand
               .Zip(secondStrand, Tuple.Create)
               .Aggregate(0, (total, pair) =>
               pair.Item1 == pair.Item2 ? total : total + 1
               );
    }
}