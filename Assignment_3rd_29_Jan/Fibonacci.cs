/* using System;

class Fibonacci{
    public static void GenerateFibonacci(int terms){
        int a = 0;
		int b = 1;
		int temp;
        Console.Write($"{a} {b} ");
        for(int i=2;i<terms;i++){
            temp = a+b;
            Console.Write($"{temp} ");
            a = b;
            b = temp;
        }
    }
    public static void Main(){
        Console.Write("Enter the number of terms: ");
        int terms = int.Parse(Console.ReadLine());
        GenerateFibonacci(terms);
    }
} */