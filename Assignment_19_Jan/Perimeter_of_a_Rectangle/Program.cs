using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter length and width of the rectangle:");
        double length = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());
        double perimeter = 2 * (length + width);
        Console.WriteLine($"Perimeter of the rectangle: {perimeter}");
    }
}
