/* using System;

class Program{
    public static void Main(){
        int[] numbers = {10,20,30};
        try{
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());
            try{
                Console.Write("Enter divisor: ");
                int divisor = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: "+(numbers[index]/divisor));
            }
            catch(DivideByZeroException){
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch(Exception ex){
            Console.WriteLine(ex.Message);
        }
    }
} */