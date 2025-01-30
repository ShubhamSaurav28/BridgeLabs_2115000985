/* using System;

class UnitConverter{
    public static double ConvertFahrenheitToCelsius(double fahrenheit){
        return (fahrenheit-32)*5/9;
    }
    public static double ConvertCelsiusToFahrenheit(double celsius){
        return (celsius*9/5)+32;
    }
    public static double ConvertPoundsToKilograms(double pounds){
        return pounds*0.453592;
    }
    public static double ConvertKilogramsToPounds(double kilograms){
        return kilograms*2.20462;
    }
    public static double ConvertGallonsToLiters(double gallons){
        return gallons*3.78541;
    }
    public static double ConvertLitersToGallons(double liters){
        return liters*0.264172;
    }
    public static void Main(string[] args){
        Console.WriteLine("Unit Converter Utility\n");
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheitInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{fahrenheitInput}°F = {ConvertFahrenheitToCelsius(fahrenheitInput):F2}°C");
        Console.Write("Enter temperature in Celsius: ");
        double celsiusInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{celsiusInput}°C = {ConvertCelsiusToFahrenheit(celsiusInput):F2}°F");
        Console.Write("Enter weight in pounds: ");
        double poundsInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{poundsInput} pounds = {ConvertPoundsToKilograms(poundsInput):F2} kilograms");
        Console.Write("Enter weight in kilograms: ");
        double kilogramsInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{kilogramsInput} kilograms = {ConvertKilogramsToPounds(kilogramsInput):F2} pounds");
        Console.Write("Enter volume in gallons: ");
        double gallonsInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{gallonsInput} gallons = {ConvertGallonsToLiters(gallonsInput):F2} liters");
        Console.Write("Enter volume in liters: ");
        double litersInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{litersInput} liters = {ConvertLitersToGallons(litersInput):F2} gallons");
    }
}
 */