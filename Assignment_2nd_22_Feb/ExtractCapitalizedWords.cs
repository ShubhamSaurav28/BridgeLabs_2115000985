/* using System;
using System.Text.RegularExpressions;

class ExtractCapitalizedWords{
    public static void Main(){
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
        MatchCollection matches = Regex.Matches(text,@"\b[A-Z][a-z]*\b");
        Console.WriteLine("Extracted Capitalized Words:");
        foreach(Match match in matches){
            Console.Write(match.Value+" ");
        }
    }
}
 */