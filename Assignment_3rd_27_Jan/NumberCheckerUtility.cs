using System;

class NumberCheckerUtility{
    public static void Main(string[] args){
        string inputNumber = Console.ReadLine();
        int[] digitArray = ConvertNumberToDigitArray(int.Parse(inputNumber));
        Console.WriteLine("Largest digit: "+GetLargestDigit(digitArray));
        Console.WriteLine("Digit count: "+GetDigitCount(int.Parse(inputNumber)));
        Console.WriteLine("Duck number: "+IsDuckNumber(digitArray));
        Console.WriteLine("Smallest digit: "+GetSmallestDigit(digitArray));
        Console.WriteLine("Armstrong number: "+IsArmstrongNumber(digitArray));
    }
    public static int[] ConvertNumberToDigitArray(int number){
        string numberAsString = number.ToString();
        int[] digitArray = new int[numberAsString.Length];
        for(int index=0;index<numberAsString.Length;index++){
            digitArray[index] = int.Parse(numberAsString[index].ToString());
        }
        return digitArray;
    }
    public static int GetDigitCount(int number){
        return number.ToString().Length;
    }
    public static bool IsArmstrongNumber(int[] digits){
        int sumOfPowers = 0;
        int originalNumber = int.Parse(string.Join("",digits));
        int numberOfDigits = digits.Length;
        foreach (int digit in digits){
            sumOfPowers += (int)Math.Pow(digit,numberOfDigits);
        }
        return sumOfPowers == originalNumber;
    }
    public static bool IsDuckNumber(int[] digits){
        foreach (int digit in digits){
            if(digit!=0){
                return true;
			}
        }
        return false;
    }
    public static int GetSmallestDigit(int[] digits){
        int smallestDigit = int.MaxValue;
        foreach(int digit in digits){
            if(digit<smallestDigit){
                smallestDigit = digit;
			}
        }
        return smallestDigit;
    }
    public static int GetLargestDigit(int[] digits){
        int largestDigit = int.MinValue;
        foreach (int digit in digits){
            if(digit>largestDigit){
                largestDigit = digit;
			}
        }
        return largestDigit;
    }
}