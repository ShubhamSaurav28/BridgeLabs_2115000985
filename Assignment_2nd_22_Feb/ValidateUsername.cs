/* using System;
using System.Text.RegularExpressions;

class ValidateUsername{
    public static bool IsValidUsername(string username){
        return Regex.IsMatch(username,@"^[a-zA-Z][a-zA-Z0-9_]{4,14}$");
    }
    public static void Main(){
        string[] testUsernames = {"user_123","123user","us","Valid_User","User12345"};
        foreach(var username in testUsernames){
            Console.WriteLine($"{username} → {(IsValidUsername(username)?"Valid":"Invalid")}");
        }
    }
}
 */