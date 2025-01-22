using System;

class VolumnOfEarth {
    public static void Main() {
        double radiusKm = 6378;
        double volumeKm = (4.0 / 3) * Math.PI * Math.Pow(radiusKm, 3);
        double volumeMiles = volumeKm / Math.Pow(1.6, 3);
        Console.WriteLine($"The volume of earth in cubic kilometers is {volumeKm3:F2} and cubic miles is {volumeMiles3:F2}");
    }
}
