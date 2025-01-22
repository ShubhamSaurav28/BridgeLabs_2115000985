using System;

class WeightConversion{
    public static void Main(){
        double pounds = double.Parse(Console.ReadLine());
        double kilograms = pounds / 2.2;
        Console.WriteLine($"The weight of the person in pounds is {pounds} and in kg is {kilograms}");
    }
}
