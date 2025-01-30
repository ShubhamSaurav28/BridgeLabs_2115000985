/* using System;

class TemperatureConverter{
    public static double FahrenheitToCelsius(double f){
		return (f-32)*5/9;
	}
    public static double CelsiusToFahrenheit(double c){
		return (c*9/5)+32;
	}
    public static void Main(){
        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());
        Console.Write("Convert to (F/C): ");
        char choice = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine(choice=='C'?$"{FahrenheitToCelsius(temp)} °C":$"{CelsiusToFahrenheit(temp)} °F");
    }
} */