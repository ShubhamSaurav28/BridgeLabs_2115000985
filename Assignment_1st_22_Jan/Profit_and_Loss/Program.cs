﻿using System;

class ProfitLoss{
	public static void Main(String[] args) {
		int costPrice = 129;
		int sellingPrice = 191;
		double profit = sellingPrice-costPrice;
		double profitPercent = (profit/costPrice)*100;
		Console.WriteLine($"The Cost Price is INR {costPrice} and Selling Price is INR {sellingPrice} \nThe Profit is INR {profit} and the Profit Percentage is {profitPercent:F2}");
	}
}