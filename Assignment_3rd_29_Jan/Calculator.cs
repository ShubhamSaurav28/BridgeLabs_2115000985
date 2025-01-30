/* using System;

class Calculator{
    public static double Add(double a, double b){
        return a+b;
    }

    public static double Subtract(double a, double b){
        return a-b;
    }

    public static double Multiply(double a, double b){
        return a*b;
    }

    public static double Divide(double a, double b){
        if(b==0){
            Console.WriteLine("Error: Division by zero is not allowed.");
            return 0;
        }
        return a/b;
    }

    public static void Main(String[] args){
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Choose operation (+, -, *, /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();
        double result = 0;
        switch (op){
            case '+':
                result = Add(num1,num2);
                break;
            case '-':
                result = Subtract(num1,num2);
                break;
            case '*':
                result = Multiply(num1,num2);
                break;
            case '/':
                result = Divide(num1,num2);
                break;
            default:
                Console.WriteLine("Error: Invalid operation");
                return;
        }
        Console.WriteLine($"Result: {result}");
    }
}
 */