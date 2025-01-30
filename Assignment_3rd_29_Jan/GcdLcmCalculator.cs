/* using System;

class GcdLcmCalculator{
    public static int GCD(int a,int b){
		return b==0?a:GCD(b,a%b);
	}
    public static int LCM(int a,int b){
		return (a*b)/GCD(a,b);
	}
    public static void Main(){
        Console.Write("Enter two numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"GCD: {GCD(a,b)}");
        Console.WriteLine($"LCM: {LCM(a,b)}");
    }
} */