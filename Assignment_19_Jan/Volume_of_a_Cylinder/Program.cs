using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter radius and height of the cylinder:");
        double cylinderRadius = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double volume = Math.PI * Math.Pow(cylinderRadius, 2) * height;
        Console.WriteLine($"Volume of the cylinder: {volume}");
    }
}
