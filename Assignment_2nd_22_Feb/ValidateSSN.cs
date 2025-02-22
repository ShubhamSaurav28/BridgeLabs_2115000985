/* using System;
using System.Text.RegularExpressions;

class ValidateSSN{
    public static void Main(){
        string[] inputs = {"123-45-6789","123456789","987-65-4321","12-345-6789"};
        string pattern = @"^\d{3}-\d{2}-\d{4}$";
        foreach(string input in inputs){
            if(Regex.IsMatch(input,pattern)){
                Console.WriteLine($"✅ \"{input}\" is valid");
            }
            else{
                Console.WriteLine($"❌ \"{input}\" is invalid");
            }
        }
    }
}
 */