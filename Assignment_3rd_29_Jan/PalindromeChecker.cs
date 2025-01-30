/* using System;

class PalindromeChecker{
    public static bool IsPalindrome(string str){
        string rev = new string(str.ToCharArray().Reverse().ToArray());
        return str.Equals(rev,StringComparison.OrdinalIgnoreCase);
    }
    public static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine(IsPalindrome(input) ? "Palindrome" : "Not a Palindrome");
    }
} */