using System;

class SamsAverage{
	public static void Main(string[] args) {
		int math = 94;
		int physics = 95;
		int chemistry = 96;
		double avg = (math+physics+chemistry)/3.0;
		Console.WriteLine($"Sam’s average mark in PCM is {avg:F2}");
	}
}
		
		