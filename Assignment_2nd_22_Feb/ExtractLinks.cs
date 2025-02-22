/* using System;
using System.Text.RegularExpressions;

class ExtractLinks{
    public static void Main(){
        string text = "Visit https://www.google.com and http://example.org for more info. Also check https://sub.domain.co.uk/page.";
        MatchCollection matches = Regex.Matches(text,@"https?://[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(/\S*)?");
        Console.WriteLine("Extracted Links:");
        foreach(Match match in matches){
            Console.WriteLine(match.Value);
        }
    }
}
 */