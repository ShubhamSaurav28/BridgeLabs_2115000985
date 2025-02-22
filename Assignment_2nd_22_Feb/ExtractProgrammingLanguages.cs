/* using System;
using System.Text.RegularExpressions;

class ExtractProgrammingLanguages{
    public static void Main(){
        string input = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        string pattern = @"\b(JavaScript|Java|Python|Go|C\+\+|C#|Ruby|Swift|PHP|Kotlin|TypeScript|Rust)\b";
        MatchCollection matches = Regex.Matches(input,pattern);
        Console.WriteLine("Extracted Programming Languages:");
        foreach(Match match in matches){
            Console.WriteLine(match.Value);
        }
    }
}
 */