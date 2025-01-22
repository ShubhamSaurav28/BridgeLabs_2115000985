using System;

class DividingPens{
	public static void Main(String[] args){
		int pens = 14;
		int students = 3;
		int pensRemaining = pens%students;
		int pensPerStudent = pens/students;
		Console.WriteLine($"The Pen Per Student is {pensPerStudent} and the remaining pen not distributed is {pensRemaining}");
	}
}