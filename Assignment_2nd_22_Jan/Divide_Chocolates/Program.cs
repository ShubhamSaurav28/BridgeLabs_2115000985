using System;

class Chocolates{
    public static void Main(){
        int chocolates = int.Parse(Console.ReadLine());
        int children = int.Parse(Console.ReadLine());
        int chocolatesPerChild = chocolates / children;
        int remainingChocolates = chocolates % children;
        Console.WriteLine($"The number of chocolates each child gets is {chocolatesPerChild} and the number of remaining chocolates is {remainingChocolates}");
    }
}
