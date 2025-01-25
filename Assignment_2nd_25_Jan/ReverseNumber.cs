/* using System;

class ReverseNumber{
    public static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int count = (int)Math.Floor(Math.Log10(number)+1);
        int[] digits = new int[count];
        for(int i=0;i<count;i++){
            digits[i] = number%10;
            number /= 10;
        }
        Console.Write("Reversed number: ");
        for(int i=0;i<count;i++){
            Console.Write(digits[i]);
        }
    }
}
  */