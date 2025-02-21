/* using System;

class Program{
    public static void Main(){
        int[] numbers = {10,20,30,40};
        try{
            Console.Write("Enter index: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine($"Value at index {index}: {numbers[index]}");
        }
        catch(IndexOutOfRangeException){
            Console.WriteLine("Invalid index!");
        }
        catch(NullReferenceException){
            Console.WriteLine("Array is not initialized!");
        }
    }
} */