/* using System;
using System.Text;

class Program{
    public static string ConcatenateStrings(string[] strings){
        StringBuilder sb = new StringBuilder();
        foreach(string str in strings){
            sb.Append(str);
        }
        return sb.ToString();
    }
    public static void Main(){
        string[] strings = {"Hello"," ","World","!"," How"," are"," you?"};
        string result = ConcatenateStrings(strings);
        Console.WriteLine($"Concatenated String: {result}");
    }
}
 */