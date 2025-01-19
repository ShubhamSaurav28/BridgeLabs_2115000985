using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers to add:");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Sum: {num1 + num2}");
    }
}
