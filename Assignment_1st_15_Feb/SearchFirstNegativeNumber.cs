/* using System;

class Program{
    public static int FindFirstNegative(int[] arr){
        foreach(int num in arr){
            if(num<0){
                return num;
			}
        }
        return int.MaxValue;
    }
    public static void Main(){
        int[] numbers = {3,7,1,0,-5,8,-10,2};
        int firstNegative = FindFirstNegative(numbers);
        if(firstNegative==int.MaxValue){
            Console.WriteLine("No negative number found.");
		}
        else{
            Console.WriteLine($"First negative number: {firstNegative}");
		}
    }
}
 */