/* using System;

class Program{
    public static void Main(){
        int[] randomNumbers = Generate4DigitRandomArray(5);
        double[] results = FindAverageMinMax(randomNumbers);
        Console.WriteLine("Generated Random 4-Digit Numbers:");
        foreach (int num in randomNumbers){
            Console.WriteLine(num);
        }
        Console.WriteLine("\nResults:");
        Console.WriteLine($"Average: {results[0]:F2}");
        Console.WriteLine($"Minimum: {results[1]}");
        Console.WriteLine($"Maximum: {results[2]}");
    }
    public static int[] Generate4DigitRandomArray(int size){
        int[] numbers = new int[size];
        Random random = new Random();
        for(int i=0;i<size;i++){
            numbers[i] = random.Next(1000,10000);
        }
        return numbers;
    }
    public static double[] FindAverageMinMax(int[] numbers){
        double[] results = new double[3];
        int sum = 0;
        int min = numbers[0];
        int max = numbers[0];
        foreach (int num in numbers){
            sum += num;
            min = Math.Min(min,num);
            max = Math.Max(max,num);
        }
        results[0] = sum/(double)numbers.Length;
        results[1] = min;
        results[2] = max;
        return results;
    }
}
 */