using System;

class DivisibleByFive{
	public static void Main(string[] args){
		int number = int.Parse(Console.ReadLine()));
		int remainder = number%5;
		bool check;
		if(remainder==0){
			check=true;
		}
		else{
			check==false;
		}
		Console.WriteLine($"Is the number {number} divisible by 5? {check}");
	}
}
