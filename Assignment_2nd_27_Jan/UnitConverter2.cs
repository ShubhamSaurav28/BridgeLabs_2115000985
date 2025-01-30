/* using System;

class UnitConverter{
    public static double ConvertYardsToFeet(double yards){
		return yards*3;
	}
	public static double ConvertFeetToYards(double feet){
		return feet*0.333333;
	}
	public static double ConvertMetersToInches(double meters){
		return meters*39.3701;
	}
	public static double ConvertInchesToMeters(double inches){
		return inches*0.0254;
	}
	public static double ConvertInchesToCentimeters(double inches){
		return inches*2.54;
	}
    public static void Main(string[] args){
        Console.Write("Enter length in yards: ");
		double yardsInput = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"{yardsInput} yards = {ConvertYardsToFeet(yardsInput):F2} feet");
		Console.Write("Enter length in feet: ");
		double feetToYardsInput = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"{feetToYardsInput} feet = {ConvertFeetToYards(feetToYardsInput):F6} yards");
		Console.Write("Enter length in meters: ");
		double metersToInchesInput = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"{metersToInchesInput} meters = {ConvertMetersToInches(metersToInchesInput):F2} inches");
		Console.Write("Enter length in inches: ");
		double inchesToMetersInput = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"{inchesToMetersInput} inches = {ConvertInchesToMeters(inchesToMetersInput):F4} meters");
		Console.Write("Enter length in inches: ");
		double inchesToCmInput = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine($"{inchesToCmInput} inches = {ConvertInchesToCentimeters(inchesToCmInput):F2} centimeters");
	}
    }
}
 */