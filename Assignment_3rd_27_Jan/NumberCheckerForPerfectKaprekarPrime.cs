using System;

class NumberCheckerForPerfectKaprekarPrime{
    public static void Main(string[] args){
        string inputNumber = Console.ReadLine();
        int number = int.Parse(inputNumber);
        Console.WriteLine("Perfect number: "+IsPerfectNumber(number));
        Console.WriteLine("Kaprekar number: "+IsKaprekarNumber(number));
        Console.WriteLine("Prime number: "+IsPrimeNumber(number));
    }
    public static bool IsPerfectNumber(int number){
        int sumOfDivisors = 0;
        for(int divisor=1;divisor<number;divisor++){
            if(number%divisor==0){
                sumOfDivisors += divisor;
			}
        }
        return sumOfDivisors == number;
    }
    public static bool IsKaprekarNumber(int number){
        int squareOfNumber = number*number;
        string squareString = squareOfNumber.ToString();
        string rightPart = squareString.Substring(squareString.Length/2);
        string leftPart = squareString.Substring(0,squareString.Length/2);
        int sumOfParts = (leftPart==""?0:int.Parse(leftPart))+int.Parse(rightPart);
        return sumOfParts==number;
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
}