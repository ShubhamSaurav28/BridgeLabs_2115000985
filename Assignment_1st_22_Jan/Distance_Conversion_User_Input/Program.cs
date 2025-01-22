using System;

class DistanceConversion {
    public static void Main() {
        double km = Convert.ToDouble(Console.ReadLine());
		double mile = km/1.6;
        Console.WriteLine($"The total miles is {mile} mile for the given {km} km");
    }
}
