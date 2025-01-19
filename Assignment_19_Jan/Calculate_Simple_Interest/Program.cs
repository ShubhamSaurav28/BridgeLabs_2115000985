using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Principal, Rate, and Time:");
        double principal = double.Parse(Console.ReadLine());
        double rate = double.Parse(Console.ReadLine());
        double time = double.Parse(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"Simple Interest: {simpleInterest}");
	}
}
