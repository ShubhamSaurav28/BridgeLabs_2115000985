/* using System;

class QuadraticEquationSolver{
    public static void FindQuadraticRoots(double a,double b,double c){
        double delta = Math.Pow(b,2)-4*a*c;
        if(delta>0){
            double root1 = (-b+Math.Sqrt(delta))/(2*a);
            double root2 = (-b-Math.Sqrt(delta))/(2*a);
            Console.WriteLine($"Two Real Roots: root1 = {root1:F2}, root2 = {root2:F2}");
        }
        else if(delta==0){
            double root = -b/(2*a);
            Console.WriteLine($"One Real Root: root = {root:F2}");
        }
        else{
            Console.WriteLine("No Real Roots (Negative Delta).");
        }
    }
    public static void Main(string[] args){
        Console.Write("Enter coefficient a: ");
        double coefA = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double coefB = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double coefC = Convert.ToDouble(Console.ReadLine());
        FindQuadraticRoots(coefA, coefB, coefC);
    }
}
 */