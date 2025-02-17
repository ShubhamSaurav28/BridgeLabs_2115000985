/* using System;

class Program {
    public static int FibonacciRecursive(int n){
		if(n<=1){
			return n;
		}
		return FibonacciRecursive(n-1)+FibonacciRecursive(n-2);
    }
	public static int FibonacciIterative(int n){
		if(n<=1){
			return n;
		}
		int a = 0;
		int b = 1;
		int sum = 0;
		for(int i=2;i<=n;i++){
			sum = a+b;
			a = b;
			b = sum;
		}
		return b;
    }
    public static void Main(){
		Console.WriteLine(FibonacciIterative(50));
		Console.WriteLine(FibonacciRecursive(10));
    }
}
 */