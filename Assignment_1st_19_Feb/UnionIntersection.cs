/* using System;
using System.Collections.Generic;

class Program{
    public static void Main(){
        HashSet<int> set1 = new HashSet<int>{1,2,3};
        HashSet<int> set2 = new HashSet<int>{3,4,5};
        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);
        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);
        Console.WriteLine($"Union: {string.Join(", ", union)}");
        Console.WriteLine($"Intersection: {string.Join(", ", intersection)}");
    }
}
 */