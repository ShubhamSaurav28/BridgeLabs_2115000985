using System;

class TriangleArea {
    public static void Main() {
        double baseCm = double.Parse(Console.ReadLine());
        double heightCm = double.Parse(Console.ReadLine());
        double area = 0.5 * baseCm * heightCm;
        Console.WriteLine($"The area of the triangle is {area} square cm.");
    }
}
