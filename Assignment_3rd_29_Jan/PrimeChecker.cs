/* using System;

class PrimeChecker{
    public static bool IsPrime(int num){
        if(num<2){
			return false;
		}
        for(int i=2;i*i<=num;i++){
            if(num%i==0){
				return false;
			}
		}
        return true;
    }
    public static void Main(){
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPrime(num) ? "Prime" : "Not Prime");
    }
} */