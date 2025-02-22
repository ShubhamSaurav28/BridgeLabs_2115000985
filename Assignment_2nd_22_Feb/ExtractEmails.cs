/* using System;
using System.Text.RegularExpressions;

class ExtractEmails{
    public static void Main(){
        string text = "Contact us at support@example.com and info@company.org. You can also reach out at help123@service.net.";
        MatchCollection matches = Regex.Matches(text,@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
        Console.WriteLine("Extracted Emails:");
        foreach(Match match in matches){
            Console.WriteLine(match.Value);
        }
    }
}
 */