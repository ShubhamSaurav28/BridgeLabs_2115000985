using System;

class HeightConversion{
	public static void Main(String[] args){
		double heightCm = double.Parse(Console.ReadLine());
		double inches = heightCm/2.54;
		double foot = inches/12;
		Console.WriteLine($"Your Height in cm is {heightCm} while in feet is {foot:f2} and inches is {inches:f2}");
	}
}