using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter distance in kilometers:");
        double kilometers = double.Parse(Console.ReadLine());
        double miles = kilometers * 0.621371;
        Console.WriteLine($"Distance in miles: {miles}");
    }
}

