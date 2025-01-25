/* using System;

class FindFactors{
    public static void Main(){
        Console.Write("Enter a number to find its factors: ");
        int number = int.Parse(Console.ReadLine());
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;
        for(int i=1;i<=number;i++){
            if(number%i==0){
                if(index==maxFactor){
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
					Array.Copy(factors, temp, factors.Length);
					factors = temp;
                }
                factors[index++] = i;
            }
        }
        Console.WriteLine("Factors:");
        for(int i=0;i<index;i++){
            Console.WriteLine(factors[i]);
        }
    }
}
  */