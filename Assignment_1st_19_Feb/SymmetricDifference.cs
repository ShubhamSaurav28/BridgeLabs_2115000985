/* using System;
using System.Collections.Generic;

class Program{
    public static void Main(){
        HashSet<int> set1 = new HashSet<int>{1,2,3};
        HashSet<int> set2 = new HashSet<int>{3,4,5};
        HashSet<int> symmetricDiff = new HashSet<int>(set1);
        symmetricDiff.SymmetricExceptWith(set2);
        Console.WriteLine($"Symmetric Difference: {string.Join(", ", symmetricDiff)}");
    }
}
 */