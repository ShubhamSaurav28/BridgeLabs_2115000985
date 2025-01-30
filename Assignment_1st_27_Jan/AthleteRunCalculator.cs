/* using System;

class AthleteRunCalculator{
    public int CalculateRounds(double side1,double side2,double side3,double distance){
        double perimeter = side1+side2+side3;
        return (int)Math.Ceiling(distance/perimeter);
    }
    public static void Main(){
        Console.Write("Enter the first side of the triangular park (m): ");
        double side1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second side: ");
        double side2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the third side: ");
        double side3 = double.Parse(Console.ReadLine());
        int rounds = CalculateRounds(side1,side2,side3,5000);
        Console.WriteLine($"The athlete needs to complete {rounds} rounds to run 5 km.");
    }
}
 */