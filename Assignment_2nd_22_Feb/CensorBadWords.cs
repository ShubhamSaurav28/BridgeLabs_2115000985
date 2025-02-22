/* using System;
using System.Text.RegularExpressions;

class CensorBadWords{
    public static void Main(){
        string input = "This is a damn bad example with some stupid words.";
        string[] badWords = {"damn","stupid"};
        foreach(string word in badWords){
            input = Regex.Replace(input,@"\b"+word + @"\b","****",RegexOptions.IgnoreCase);
        }
        Console.WriteLine("Censored Text:");
        Console.WriteLine(input);
    }
}
 */