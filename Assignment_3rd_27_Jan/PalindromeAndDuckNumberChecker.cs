using System;

class PalindromeAndDuckNumberChecker{
    public static void Main(string[] args){
        string inputNumber = Console.ReadLine();
        int[] digitArray = ConvertNumberToDigitArray(int.Parse(inputNumber));
        Console.WriteLine("Reverse digits: "+string.Join(",",ReverseDigits(digitArray)));
        Console.WriteLine("Palindrome: "+IsPalindrome(digitArray));
    }
    public static int[] ConvertNumberToDigitArray(int number){
        string numberAsString = number.ToString();
        int[] digitArray = new int[numberAsString.Length];
        for(int index=0;index<numberAsString.Length;index++){
            digitArray[index] = int.Parse(numberAsString[index].ToString());
        }
        return digitArray;
    }
    public static int[] ReverseDigits(int[] digits){
        Array.Reverse(digits);
        return digits;
    }
    public static bool IsPalindrome(int[] digits){
        int[] reversedDigits = ReverseDigits((int[])digits.Clone());
        for(int index=0;index<digits.Length;index++){
            if(digits[index]!=reversedDigits[index]){
                return false;
			}
        }
        return true;
    }
}