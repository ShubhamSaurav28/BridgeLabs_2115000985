/* using System;

class LargestSecondLargest{
    public static void Main(){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int[] digits = new int[10];
        int index = 0;
        int maxDigit = 10;
        while(number!=0){
            digits[index++] = number%10;
            number /= 10;
        }
        int largest = 0;
		int secondLargest = 0;
        foreach(int digit in digits){
            if(digit>largest){
                secondLargest = largest;
                largest = digit;
            }
            else if(digit>secondLargest && digit<largest){
                secondLargest = digit;
            }
        }
        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}
  */