using System;

class GeometryOperations{
    public static void Main(string[] args){
        Console.Write("Enter the x-coordinate of the first point (x1): ");
        double xCoordinate1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the y-coordinate of the first point (y1): ");
        double yCoordinate1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the x-coordinate of the second point (x2): ");
        double xCoordinate2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the y-coordinate of the second point (y2): ");
        double yCoordinate2 = double.Parse(Console.ReadLine());
        double distance = CalculateDistance(xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2);
        Console.WriteLine($"The Euclidean distance between the two points is: {distance:F2}");
        string lineEquation = CalculateLineEquation(xCoordinate1, yCoordinate1, xCoordinate2, yCoordinate2);
        Console.WriteLine($"The equation of the line passing through the points is: {lineEquation}");
    }
    public static double CalculateDistance(double x1, double y1, double x2, double y2){
        return Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2));
    }
    public static string CalculateLineEquation(double x1, double y1, double x2, double y2){
        if(x1==x2){
            return $"x = {x1} (The line is vertical, slope is undefined)";
        }
        else{
            double slope = (y2-y1)/(x2-x1);
            double intercept = y1 - slope*x1;
            return $"y = {slope:F2}x + {intercept:F2}";
        }
    }
}