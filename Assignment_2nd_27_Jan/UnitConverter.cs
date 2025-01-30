/* using System;

class UnitConverter{
    public static double ConvertKilometersToMiles(double kilometers){
		return kilometers*0.621371;
	}
    public static double ConvertMilesToKilometers(double miles){
		return miles*1.60934;
	}
    public static double ConvertMetersToFeet(double meters){
		return meters*3.28084;
	}
    public static double ConvertFeetToMeters(double feet){
		return feet*0.3048;
	}
    public static void Main(string[] args){
        Console.WriteLine("Unit Converter\n");
        Console.Write("Enter distance in kilometers: ");
        double kmInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{kmInput} kilometers = {ConvertKilometersToMiles(kmInput):F2} miles");
        Console.Write("Enter distance in miles: ");
        double milesInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{milesInput} miles = {ConvertMilesToKilometers(milesInput):F2} kilometers");
        Console.Write("Enter distance in meters: ");
        double metersInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{metersInput} meters = {ConvertMetersToFeet(metersInput):F2} feet");
        Console.Write("Enter distance in feet: ");
        double feetInput = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feetInput} feet = {ConvertFeetToMeters(feetInput):F2} meters");
    }
}
 */