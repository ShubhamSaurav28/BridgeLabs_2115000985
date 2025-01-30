/* using System;

class FactorAnalysis{
    public static int[] GetFactors(int userInput){
        int factorCount = 0;
        for(int i=1;i<=userInput;i++){
            if(userInput%i==0){
				factorCount++;
			}
        }
        int[] factors = new int[factorCount];
        int index = 0;
        for(int i=1;i<=userInput;i++){
            if(userInput%i==0){
				factors[index++] = i;
			}
        }
        return factors;
    }
    public static int CalculateSum(int[] factorList){
        int sumFactors = 0;
        foreach (int factor in factorList){
            sumFactors += factor;
        }
        return sumFactors;
    }
    public static long CalculateProduct(int[] factorList){
        long productFactors = 1;
        foreach (int factor in factorList){
            productFactors *= factor;
        }
        return productFactors;
    }
    public static int SumOfSquares(int[] factorList){
        int squareSum = 0;
        foreach (int factor in factorList){
            squareSum += (int)Math.Pow(factor,2);
        }
        return squareSum;
    }
    public static void Main(string[] args){
        Console.Write("Enter a number to find its factors: ");
        int inputNumber = int.Parse(Console.ReadLine());
        int[] factorList = GetFactors(inputNumber);
        Console.WriteLine($"Factors: {string.Join(", ", factorList)}");
        Console.WriteLine($"Sum of Factors: {CalculateSum(factorList)}");
        Console.WriteLine($"Product of Factors: {CalculateProduct(factorList)}");
        Console.WriteLine($"Sum of Squares of Factors: {SumOfSquares(factorList)}");
    }
}
 */