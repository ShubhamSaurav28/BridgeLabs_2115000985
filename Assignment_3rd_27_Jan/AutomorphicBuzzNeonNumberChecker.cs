using System;

class AutomorphicBuzzNeonNumberChecker{
    public static void Main(string[] args){
        string inputNumber = Console.ReadLine();
        int number = int.Parse(inputNumber);
        Console.WriteLine("Automorphic number: "+IsAutomorphicNumber(number));
        Console.WriteLine("Buzz number: "+IsBuzzNumber(number));
        Console.WriteLine("Neon number: "+IsNeonNumber(number));
    }
    public static bool IsAutomorphicNumber(int number){
        int squareOfNumber = number*number;
        return squareOfNumber.ToString().EndsWith(number.ToString());
    }
    public static bool IsBuzzNumber(int number){
        return number%7==0 || number.ToString().EndsWith("7");
    }
    public static bool IsNeonNumber(int number){
        int squareOfNumber = number*number;
        int sumOfDigits = 0;
        while(squareOfNumber>0){
            sumOfDigits += squareOfNumber%10;
            squareOfNumber /= 10;
        }
        return sumOfDigits==number;
    }
}