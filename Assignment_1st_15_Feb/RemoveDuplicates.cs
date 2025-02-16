/* using System;
using System.Text;
using System.Collections.Generic;

class Program{
    public static string RemoveDuplicates(string input){
        HashSet<char> seen = new HashSet<char>();
        StringBuilder sb = new StringBuilder();
        foreach(char c in input){
            if(!seen.Contains(c)){
                seen.Add(c);
                sb.Append(c);
            }
        }
        return sb.ToString();
    }
    public static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string result = RemoveDuplicates(input);
        Console.WriteLine($"String after removing duplicates: {result}");
    }
}
 */