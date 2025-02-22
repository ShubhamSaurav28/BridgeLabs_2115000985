/* using System;
using System.Text.RegularExpressions;

class ValidateHexColor{
    public static bool IsValidHexColor(string color){
        return Regex.IsMatch(color,@"^#[0-9A-Fa-f]{6}$");
    }
    public static void Main(){
        string[] testColors = {"#FFA500","#ff4500","#123","#ABCDEF","#a1b2c3","123456"};
        foreach(var color in testColors){
            Console.WriteLine($"{color} → {(IsValidHexColor(color)?"Valid":"Invalid")}");
        }
    }
}
 */