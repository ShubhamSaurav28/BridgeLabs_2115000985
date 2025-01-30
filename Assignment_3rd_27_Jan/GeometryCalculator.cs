using System;

class GeometryCalculator{
    public static double CalculateEuclideanDistance(double xCoordinate1,double yCoordinate1,double xCoordinate2,double yCoordinate2){
        double distance = Math.Sqrt(Math.Pow(xCoordinate2 - xCoordinate1, 2) + Math.Pow(yCoordinate2 - yCoordinate1, 2));
        return distance;
    }
    public static double[] CalculateLineEquation(double xCoordinate1,double yCoordinate1,double xCoordinate2,double yCoordinate2){
        double[] lineEquationParameters = new double[2];
        double slope = (yCoordinate2-yCoordinate1)/(xCoordinate2-xCoordinate1);
        double yIntercept = yCoordinate1-(slope*xCoordinate1);
        lineEquationParameters[0] = slope;
        lineEquationParameters[1] = yIntercept;
        return lineEquationParameters;
    }
    public static void Main(string[] args){
        Console.Write("Enter the x-coordinate of the first point: ");
        double xCoordinate1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the y-coordinate of the first point: ");
        double yCoordinate1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the x-coordinate of the second point: ");
        double xCoordinate2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the y-coordinate of the second point: ");
        double yCoordinate2 = double.Parse(Console.ReadLine());
        double euclideanDistance = CalculateEuclideanDistance(xCoordinate1,yCoordinate1,xCoordinate2,yCoordinate2);
        Console.WriteLine($"The Euclidean distance between the points is: {euclideanDistance}");
        double[] lineEquationParameters = CalculateLineEquation(xCoordinate1,yCoordinate1,xCoordinate2,yCoordinate2);
        Console.WriteLine($"The equation of the line passing through the points is: y = {lineEquationParameters[0]}x + {lineEquationParameters[1]}");
    }
}