/* using System;

class ChocolateDistributor{
    public static int[] DistributeChocolates(int chocolates,int children){
        int eachGets = chocolates/children;
        int remaining = chocolates%children;
        return new int[] { eachGets, remaining };
    }
    public static void Main(){
        Console.Write("Enter number of chocolates: ");
        int chocolates = int.Parse(Console.ReadLine());
        Console.Write("Enter number of children: ");
        int children = int.Parse(Console.ReadLine());
        int[] result = DistributeChocolates(chocolates, children);
        Console.WriteLine($"Each child gets {result[0]} chocolates, remaining: {result[1]}.");
    }
}
 */