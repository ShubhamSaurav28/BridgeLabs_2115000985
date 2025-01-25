/* using System;

class LargestSecondLargestAgain{
    public static void Main(){
        Console.Write("Enter a number: ");
        long number = long.Parse(Console.ReadLine());
        int[] digits = new int[10];
        int index = 0;
        int maxDigit = 10;
        while(number!=0){
            if(index==maxDigit){
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, digits.Length);
                digits = temp;
            }
            digits[index++] = (int)number%10;
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