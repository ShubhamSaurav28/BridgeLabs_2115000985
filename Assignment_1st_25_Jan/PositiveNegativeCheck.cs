/* using System;

class PositiveNegativeCheck{
    public static void Main(){
        int[] numbers = new int[5];
        Console.WriteLine("Enter 5 numbers:");
        for(int i=0;i<numbers.Length;i++){
            numbers[i] = int.Parse(Console.ReadLine());
        }
        foreach(int num in numbers){
            if(num>0){
                Console.WriteLine($"{num} is Positive and {(num%2==0?"Even":"Odd")}");
            }
            else if(num<0){
                Console.WriteLine($"{num} is Negative");
            }
            else{
                Console.WriteLine($"{num} is Zero");
            }
        }

        if(numbers[0]==numbers[numbers.Length-1]){
            Console.WriteLine($"First element {numbers[0]} is equal to last element {numbers[numbers.Length-1]}.");
		}
        else if(numbers[0]>numbers[numbers.Length-1]){
            Console.WriteLine($"First element {numbers[0]} is greater than last element {numbers[numbers.Length-1]}.");
		}
        else{
            Console.WriteLine($"First element {numbers[0]} is less than last element {numbers[numbers.Length-1]}.");
		}
    }
}
 */