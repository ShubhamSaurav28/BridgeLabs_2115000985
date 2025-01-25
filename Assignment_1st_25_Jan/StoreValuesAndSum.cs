/* using System;

class StoreValuesAndSum{
    public static void Main(){
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;
        Console.WriteLine("Enter numbers (0 or negative number to stop):");
        while(true){
            double input = double.Parse(Console.ReadLine());
            if(input<=0 || index>=numbers.Length){
                break;
			}
            numbers[index] = input;
            index++;
        }
        for(int i=0;i<index;i++){
            total += numbers[i];
        }
        Console.WriteLine("Entered numbers:");
        for(int i=0;i<index;i++){
            Console.WriteLine(numbers[i]);
        }
        Console.WriteLine($"Sum of numbers: {total}");
    }
}
 */