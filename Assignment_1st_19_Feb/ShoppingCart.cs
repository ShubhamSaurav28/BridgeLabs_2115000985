/* using System;
using System.Collections.Generic;

class Program{
    public static void Main(){
        Dictionary<string,double> prices = new Dictionary<string,double>{{"Laptop",1000.0},{"Mouse",20.0},{"Keyboard",50.0}};
        SortedDictionary<string,double> sortedPrices = new SortedDictionary<string,double>(prices);
        Console.WriteLine("Sorted Cart Items by Price:");
        foreach(var item in sortedPrices){
            Console.WriteLine($"{item.Key}: ${item.Value}");
		}
    }
}
 */