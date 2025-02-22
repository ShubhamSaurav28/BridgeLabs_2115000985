/* using System;
using System.Text.RegularExpressions;

class ExtractCurrencyValues{
    public static void Main(){
        string input = "The price is $45.99, and the discount is $ 10.50.";
        string pattern = @"\$?\s*\d+\.\d{2}";
        MatchCollection matches = Regex.Matches(input,pattern);
        Console.WriteLine("Extracted Currency Values:");
        foreach(Match match in matches){
            Console.WriteLine(match.Value.Trim());
        }
    }
}
 */