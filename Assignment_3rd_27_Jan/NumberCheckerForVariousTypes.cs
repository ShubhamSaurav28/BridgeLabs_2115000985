using System;

class NumberCheckerForVariousTypes{
    public static void Main(string[] args){
        string inputNumber = Console.ReadLine();
        Console.WriteLine("Prime number: "+IsPrimeNumber(int.Parse(inputNumber)));
        Console.WriteLine("Neon number: "+IsNeonNumber(int.Parse(inputNumber)));
        Console.WriteLine("Spy number: "+IsSpyNumber(int.Parse(inputNumber)));
        Console.WriteLine("Automorphic number: "+IsAutomorphicNumber(int.Parse(inputNumber)));
        Console.WriteLine("Buzz number: "+IsBuzzNumber(int.Parse(inputNumber)));
    }
    public static bool IsPrimeNumber(int number){
        if(number<=1){
			return false;
		}
        for(int divisor=2;divisor<=Math.Sqrt(number);divisor++){
            if(number%divisor==0){
                return false;
			}
        }
        return true;
    }
    public static bool IsBuzzNumber(int number){
        return number%7==0||number.ToString().EndsWith("7");
    }
    public static bool IsNeonNumber(int number){
        int squareOfNumber = number*number;
        int sumOfDigits = 0;
        while(squareOfNumber>0){
            sumOfDigits += squareOfNumber % 10;
            squareOfNumber /= 10;
        }
        return sumOfDigits==number;
    }
    public static bool IsAutomorphicNumber(int number){
        int squareOfNumber = number*number;
        return squareOfNumber.ToString().EndsWith(number.ToString());
    }
    public static bool IsSpyNumber(int number){
        int sumOfDigits = 0, productOfDigits = 1;
        while(number>0){
            int digit = number%10;
            sumOfDigits += digit;
            productOfDigits *= digit;
            number /= 10;
        }
        return sumOfDigits==productOfDigits;
    }
}