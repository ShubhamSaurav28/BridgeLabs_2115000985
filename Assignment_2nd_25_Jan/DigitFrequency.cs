/* using System;

class DigitFrequency{
    public static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] digits = new int[10];
        while(number!=0){
            digits[number%10]++;
            number /= 10;
        }
        Console.WriteLine("Digit frequency:");
        for(int i=0;i<10;i++){
            if(digits[i]>0){
                Console.WriteLine($"Digit {i}: {digits[i]} times");
			}
        }
    }
}
  */