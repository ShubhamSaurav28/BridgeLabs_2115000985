using System;

class TripDetails{
    public static void Main(){
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter fromCity:");
        string fromCity = Console.ReadLine();
        Console.WriteLine("Enter viaCity:");
        string viaCity = Console.ReadLine();
        Console.WriteLine("Enter toCity:");
        string toCity = Console.ReadLine();
        Console.WriteLine("Enter fromToVia distance(km):");
        double fromToVia = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter viaToFinalCity distance(km):");
        double viaToFinalCity = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter timeTaken(minutes):");
        double timeTaken = double.Parse(Console.ReadLine());
        double totalDistance = fromToVia + viaToFinalCity;
        Console.WriteLine($"The results of the trip are Name: {name}, from {fromCity} to {toCity} via {viaCity},  Total Distance: {totalDistance} km, Time Taken: {timeTaken} minutes.");
    }
}
