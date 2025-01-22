using System;

class FeetYardMile {
    public static void Main() {
        double distanceFeet = double.Parse(Console.ReadLine());
        double distanceYards = distanceFeet / 3;
        double distanceMiles = distanceYards / 1760;
        Console.WriteLine($"The distance is {distanceFeet:F2} feet, {distanceYards:F2} yards, and {distanceMiles:F2} miles.");
    }
}
