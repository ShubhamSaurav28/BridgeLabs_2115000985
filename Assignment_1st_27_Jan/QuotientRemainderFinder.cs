/* using System;

class QuotientRemainderFinder{
    public static int[] FindRemainderAndQuotient(int number,int divisor){
        int quotient = number/divisor;
        int remainder = number%divisor;
        return new int[] {quotient,remainder};
    }
    public static void Main(){
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter divisor: ");
        int divisor = int.Parse(Console.ReadLine());
        int[] result = FindRemainderAndQuotient(number,divisor);
        Console.WriteLine($"Quotient: {result[0]}, Remainder: {result[1]}");
    }
}
 */