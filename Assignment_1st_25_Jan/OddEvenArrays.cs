/*  using System;

class OddEvenArrays{
    public static void Main(){
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());
        if(number<=0){
            Console.WriteLine("Error: Please enter a natural number.");
            return;
        }
        int[] oddNumbers = new int[number/2+1];
        int[] evenNumbers = new int[number/2+1];
        int oddIndex = 0;
		int evenIndex = 0;
        for(int i=1;i<=number;i++){
            if(i%2==0){
                evenNumbers[evenIndex++] = i;
            }
            else{
                oddNumbers[oddIndex++] = i;
            }
        }
        Console.WriteLine("Odd numbers:");
        for(int i=0;i<oddIndex;i++){
            Console.WriteLine(oddNumbers[i]);
        }
        Console.WriteLine("Even numbers:");
        for(int i=0;i<evenIndex;i++){
            Console.WriteLine(evenNumbers[i]);
        }
    }
}
  */