/* using System;

class SmallestOfThree{
	public static void Main(string[] args){
		int number1 = int.Parse(Console.ReadLine());
		int number2 = int.Parse(Console.ReadLine());
		int number3 = int.Parse(Console.ReadLine());
		int smallest;
		if(number1>number2 && number3>number2){
			smallest = number2;
		}
		else if(number1>number3 && number2>number3){
			smallest = number3;
		}
		else{
			smallest = number1;
		}
		Console.WriteLine($"Is the first number the smallest? {smallest==number1}");
	}
} */