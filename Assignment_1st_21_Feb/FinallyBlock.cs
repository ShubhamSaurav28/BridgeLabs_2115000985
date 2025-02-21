/* using System;

class Program{
    public static void Main(){
        try{
            Console.Write("Enter numerator: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            int denom = int.Parse(Console.ReadLine());
            Console.WriteLine("Result: "+(num/denom));
        }
        catch(DivideByZeroException){
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        finally{
            Console.WriteLine("Operation completed");
        }
    }
} */