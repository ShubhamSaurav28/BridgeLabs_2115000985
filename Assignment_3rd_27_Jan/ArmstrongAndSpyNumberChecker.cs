using System;

class ArmstrongAndSpyNumberChecker{
    public static void Main(string[] args){
        string inputNumber = Console.ReadLine();
        int number = int.Parse(inputNumber);
        Console.WriteLine("Armstrong number: "+IsArmstrongNumber(number));
        Console.WriteLine("Spy number: "+IsSpyNumber(number));
    }
    public static bool IsArmstrongNumber(int number){
        int numberOfDigits = number.ToString().Length;
        int sumOfPowers = 0;
        int originalNumber = number;
        while(number>0){
            int digit = number%10;
            sumOfPowers += (int)Math.Pow(digit,numberOfDigits);
            number /= 10;
        }
        return sumOfPowers==originalNumber;
    }
    public static bool IsSpyNumber(int number){
        int sumOfDigits = 0;
        int productOfDigits = 1;
        while(number>0){
            int digit = number%10;
            sumOfDigits += digit;
            productOfDigits *= digit;
            number /= 10;
        }
        return sumOfDigits==productOfDigits;
    }
}