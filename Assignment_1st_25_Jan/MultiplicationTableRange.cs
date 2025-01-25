/* using System;

class MultiplicationTableRange{
    public static void Main(){
        Console.Write("Enter a number to generate multiplication tables from 6 to 9: ");
        int number = int.Parse(Console.ReadLine());
		if(number<6 || number>9){
            Console.WriteLine("Invalid input. Please enter a number between 6 and 9.");
            return;
        }
        int[] results = new int[10];
        for(int i=0;i<results.Length;i++){
            results[i] = number*(i+1);
        }
        for(int i=0;i<results.Length;i++){
            Console.WriteLine($"{number}*{i+1} = {results[i]}");
        }
    }
}
  */