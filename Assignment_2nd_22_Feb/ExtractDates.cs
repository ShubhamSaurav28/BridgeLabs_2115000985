/* using System;
using System.Text.RegularExpressions;

class ExtractDates{
    public static void Main(){
        string text = "The events are scheduled for 12/05/2023, 15/08/2024, and 29/02/2020. Another date 01/01/1999.";
        MatchCollection matches = Regex.Matches(text,@"\b(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}\b");
        Console.WriteLine("Extracted Dates:");
        foreach(Match match in matches){
            Console.WriteLine(match.Value);
        }
    }
}
 */