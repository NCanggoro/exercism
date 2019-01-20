using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var newString = "";
        for(int i = input.Length - 1; i >= 0; i--)
        {
            newString += input[i];
        }

        return newString;
    }
}