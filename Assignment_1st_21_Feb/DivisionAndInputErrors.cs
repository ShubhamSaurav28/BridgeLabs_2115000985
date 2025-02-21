/* using System;

class Program{
    public static void Main(){
        try{
            Console.Write("Enter numerator: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            int denom = int.Parse(Console.ReadLine());
            int result = num/denom;
            Console.WriteLine("Result: "+result);
        }
        catch(DivideByZeroException){
            Console.WriteLine("Error: Cannot divide by zero!");
        }
        catch(FormatException){
            Console.WriteLine("Error: Invalid input! Please enter numeric values.");
        }
    }
} */