/* using System;

class TrigonometricCalculator{
    public double[] CalculateTrigFunctions(double angle){
        double radians = Math.PI*angle/180;
        return new double[] {Math.Sin(radians),Math.Cos(radians),Math.Tan(radians)};
    }
    public static void Main(){
        Console.Write("Enter angle (degrees): ");
        double angle = double.Parse(Console.ReadLine());
        double[] trigValues = CalculateTrigFunctions(angle);
        Console.WriteLine($"Sin: {trigValues[0]:F2}, Cos: {trigValues[1]:F2}, Tan: {trigValues[2]:F2}");
    }
}
 */