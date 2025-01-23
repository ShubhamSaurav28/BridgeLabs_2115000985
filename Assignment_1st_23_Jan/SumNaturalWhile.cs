/* using System;

class SumNaturalWhile{
	public static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        if(n>=0){
            int formulaSum = n*(n+1)/2;
            int computedSum = 0;
            int i = 1;
            while(i<=n){
                computedSum += i;
                i++;
            }
            Console.WriteLine($"Sum using formula: {formulaSum}");
            Console.WriteLine($"Sum using while loop: {computedSum}");
            Console.WriteLine($"Are both results equal? {formulaSum == computedSum}");
        }
        else{
            Console.WriteLine("The input is not a natural number.");
        }
	}
}
	 */