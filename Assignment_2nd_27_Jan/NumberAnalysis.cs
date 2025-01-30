/* using System;

class NumberAnalysis{
    public static string CheckSign(int number){
        return number>=0?"Positive":"Negative";
    }
    public static string CheckEvenOdd(int number){
        return number%2==0?"Even":"Odd";
    }
    public static int CompareNumbers(int num1,int num2){
        return num1.CompareTo(num2);
    }
    public static void Main(string[] args){
        int[] numbers = new int[5];
        for(int i=0;i<numbers.Length;i++){
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i<numbers.Length;i++){
            string signStatus = CheckSign(numbers[i]);
            Console.WriteLine($"Number {numbers[i]} is {signStatus}");
            if(signStatus=="Positive"){
                string evenOddStatus = CheckEvenOdd(numbers[i]);
                Console.WriteLine($"Number {numbers[i]} is {evenOddStatus}");
            }
        }
        int comparisonResult = CompareNumbers(numbers[0],numbers[^1]);
        switch (comparisonResult){
            case 1:
                Console.WriteLine($"The first element ({numbers[0]}) is greater than the last element ({numbers[^1]}).");
                break;
            case 0:
                Console.WriteLine($"The first element ({numbers[0]}) is equal to the last element ({numbers[^1]}).");
                break;
            case -1:
                Console.WriteLine($"The first element ({numbers[0]}) is less than the last element ({numbers[^1]}).");
                break;
        }
        Console.WriteLine($"The first element ({numbers[0]}) is {comparisonMessage} the last element ({numbers[^1]}).");
    }
}
 */