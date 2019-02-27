using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        string acronym = "";
        foreach(string word in Regex.Split(phrase, @"\W+"))
        {
            if(Regex.IsMatch(word, @"[a-z]"))
            {
                string firstLetter = word.First().ToString().ToUpper() + word.Substring(1);
                acronym += Regex.Replace(firstLetter, @"[^A-Z]", "");
            }
            else if(word != "")
            {
                acronym += word.First();
            }
        }

        return acronym; // TODO Pass Apostrophes test
    }
}