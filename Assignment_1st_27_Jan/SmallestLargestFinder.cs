/* using System;

class SmallestLargestFinder{
    public static int[] FindSmallestAndLargest(int number1,int number2,int number3){
        int smallest = Math.Min(number1,Math.Min(number2,number3));
        int largest = Math.Max(number1,Math.Max(number2,number3));
        return new int[] {smallest,largest};
    }
    public static void Main(){
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        int number3 = int.Parse(Console.ReadLine());
        int[] result = FindSmallestAndLargest(number1,number2,number3);
        Console.WriteLine($"Smallest: {result[0]}, Largest: {result[1]}");
    }
}
 */