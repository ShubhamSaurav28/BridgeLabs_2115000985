using System;

class UniversityPercent{
	public static void Main(String[] args){
		int fee = 125000;
		int discount = 10;
		double discountedAmount = fee*discount/100;
		double discountedPrice = fee-discountedAmount;
		Console.WriteLine($"The discount amount is INR {discountedAmount} and final discounted fee is INR {discountedPrice}");
	}
}