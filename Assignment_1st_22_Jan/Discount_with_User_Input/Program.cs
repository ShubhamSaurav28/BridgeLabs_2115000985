using System;

class UniversityPercent{
	public static void Main(String[] args){
		int fee = int.Parse(Console.ReadLine());
		int discount = int.Parse(Console.ReadLine());
		double discountedAmount = fee*discount/100.00;
		double discountedPrice = fee-discountedAmount;
		Console.WriteLine($"The discount amount is INR {discountedAmount:f2} and final discounted fee is INR {discountedPrice:f2}");
	}
}