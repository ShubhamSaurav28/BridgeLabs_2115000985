using System;

class TemperatureConversion{
    public static void Main(){
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"The {celsius} Celsius is {fahrenheit:f2} Fahrenheit");
    }
}
