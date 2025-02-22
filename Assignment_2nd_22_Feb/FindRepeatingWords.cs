/* using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class FindRepeatingWords{
    public static void Main(){
        string input = "This is is a repeated repeated word test.";
        string pattern = @"\b(\w+)\s+\1\b";
        MatchCollection matches = Regex.Matches(input,pattern,RegexOptions.IgnoreCase);
        HashSet<string> uniqueWords = new HashSet<string>();
        Console.WriteLine("Repeating Words:");
        foreach(Match match in matches){
            uniqueWords.Add(match.Groups[1].Value);
        }
        Console.WriteLine(string.Join(", ",uniqueWords));
    }
}
 */