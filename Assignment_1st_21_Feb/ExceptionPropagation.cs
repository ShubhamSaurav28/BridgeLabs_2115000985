/* using System;

class Program{
    public static void Method1(){
        throw new ArithmeticException("Division by zero!");
    }
    public static void Method2(){
        Method1();
    }
    public static void Main(){
        try{
            Method2();
        }
        catch(ArithmeticException){
            Console.WriteLine("Handled exception in Main");
        }
    }
} */