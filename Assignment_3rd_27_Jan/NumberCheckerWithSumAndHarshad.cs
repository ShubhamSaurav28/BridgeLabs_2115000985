using System;

class NumberCheckerWithSumAndHarshad{
    public static void Main(string[] args){
        string inputNumber = Console.ReadLine();
        int[] digitArray = ConvertNumberToDigitArray(int.Parse(inputNumber));
        Console.WriteLine("Sum of digits: "+CalculateDigitSum(digitArray));
        Console.WriteLine("Sum of squares of digits: "+CalculateSumOfSquares(digitArray));
        Console.WriteLine("Harshad number: "+IsHarshadNumber(digitArray));
    }
    public static int[] ConvertNumberToDigitArray(int number){
        string numberAsString = number.ToString();
        int[] digitArray = new int[numberAsString.Length];
        for(int index=0;index<numberAsString.Length;index++){
            digitArray[index] = int.Parse(numberAsString[index].ToString());
        }
        return digitArray;
    }
    public static int CalculateDigitSum(int[] digits){
        int digitSum = 0;
        foreach (int digit in digits){
            digitSum += digit;
        }
        return digitSum;
    }
    public static double CalculateSumOfSquares(int[] digits){
        double sumOfSquares = 0;
        foreach (int digit in digits){
            sumOfSquares += Math.Pow(digit,2);
        }
        return sumOfSquares;
    }
    public static bool IsHarshadNumber(int[] digits){
        int digitSum = CalculateDigitSum(digits);
        int number = int.Parse(string.Join("",digits));
        return number % digitSum == 0;
    }
}