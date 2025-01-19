using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter base and exponent:");
        double baseNum = double.Parse(Console.ReadLine());
        double exponent = double.Parse(Console.ReadLine());
        double power = Math.Pow(baseNum, exponent);
        Console.WriteLine($"Result: {power}");
    }
}
