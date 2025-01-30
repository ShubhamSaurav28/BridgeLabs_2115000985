/* using System;

class NaturalNumberSum{
    public static int CalculateSumRecursively(int n){
        if (n==1){
			return 1;
		}
        return n+CalculateSumRecursively(n-1);
    }
    public static int CalculateSumUsingFormula(int n){
        return n*(n+1)/2;
    }
    public static void Main(string[] args){
        Console.Write("Enter a natural number: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        if(userInput<=0){
            Console.WriteLine("Invalid input. Please enter a positive natural number.");
            return;
        }
        int recursiveSum = CalculateSumRecursively(userInput);
        int formulaSum = CalculateSumUsingFormula(userInput);
        Console.WriteLine($"Sum using Recursion: {recursiveSum}");
        Console.WriteLine($"Sum using Formula: {formulaSum}");
        if(recursiveSum==formulaSum){
            Console.WriteLine("Both methods yield the same result.");
        }
        else{
            Console.WriteLine("Discrepancy in the results. Please check the logic.");
        }
    }
}
 */