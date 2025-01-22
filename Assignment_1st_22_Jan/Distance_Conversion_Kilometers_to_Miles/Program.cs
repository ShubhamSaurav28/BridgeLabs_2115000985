using System;

class kiloConvertMiles{
	public static void Main(String[] args){
		double kilometer =  10.8;
		double mile = kilometer/1.6;
		Console.WriteLine($"The distance {kilometer} km in miles is {mile:F2}");
	}
}
		