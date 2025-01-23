/* using System;

class SumNaturalFor{
	public static void Main(string[] args){
        int n = int.Parse(Console.ReadLine());
        if(n>=0){
            int formulaSum = n*(n+1)/2;
            int computedSum = 0;
            for (int i=1;i<=n;i++){
                computedSum += i;
            }
            Console.WriteLine($"Sum using formula: {formulaSum}");
            Console.WriteLine($"Sum using for loop: {computedSum}");
            Console.WriteLine($"Are both results equal? {formulaSum == computedSum}");
        }
        else{
            Console.WriteLine("The input is not a natural number.");
        }
	}
}
	 */