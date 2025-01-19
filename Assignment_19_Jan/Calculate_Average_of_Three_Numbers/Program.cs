using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers:");
        double numA = double.Parse(Console.ReadLine());
        double numB = double.Parse(Console.ReadLine());
        double numC = double.Parse(Console.ReadLine());
        double average = (numA + numB + numC) / 3;
        Console.WriteLine($"Average: {average}");
    }
}
