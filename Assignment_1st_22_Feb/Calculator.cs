//using System;

//public class Calculator
//{
//    public int Add(int a, int b) => a + b;
//    public int Subtract(int a, int b) => a - b;
//    public int Multiply(int a, int b) => a * b;

//    public int Divide(int a, int b)
//    {
//        if (b == 0)
//            throw new DivideByZeroException("Cannot divide by zero.");
//        return a / b;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Calculator calc = new Calculator();

//        Console.WriteLine("Addition: " + calc.Add(5, 3));          // 8
//        Console.WriteLine("Subtraction: " + calc.Subtract(5, 3));  // 2
//        Console.WriteLine("Multiplication: " + calc.Multiply(5, 3)); // 15

//        try
//        {
//            Console.WriteLine("Division: " + calc.Divide(10, 2));  // 5
//            Console.WriteLine("Division by zero: " + calc.Divide(10, 0)); // Should throw exception
//        }
//        catch (DivideByZeroException ex)
//        {
//            Console.WriteLine("Error: " + ex.Message);
//        }
//    }
//}
