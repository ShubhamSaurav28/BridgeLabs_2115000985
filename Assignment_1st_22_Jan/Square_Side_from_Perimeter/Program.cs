using System;

class Perimeter {
    public static void Main() {
        double perimeter = double.Parse(Console.ReadLine());
        double side = perimeter / 4;
        Console.WriteLine($"The length of the side is {side} whose perimeter is {perimeter}");
    }
}

