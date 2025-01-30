/* using System;

class WindChillCalculator{
    public double CalculateWindChill(double temp,double windSpeed){
        return 35.74+0.6215*temp+(0.4275*temp-35.75)*Math.Pow(windSpeed,0.16);
    }
    public static void Main(){
        Console.Write("Enter temperature (°F): ");
        double temp = double.Parse(Console.ReadLine());
        Console.Write("Enter wind speed (mph): ");
        double windSpeed = double.Parse(Console.ReadLine());
        double windChill = CalculateWindChill(temp,windSpeed);
        Console.WriteLine($"The wind chill is {windChill:F2}°F.");
    }
}
 */