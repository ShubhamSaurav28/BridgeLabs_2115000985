/* using System;
using System.Collections.Generic;

class Program{
    public static bool IsSubset(HashSet<int> subset,HashSet<int> superset){
        return superset.IsSupersetOf(subset);
    }
    public static void Main(){
        HashSet<int> set1 = new HashSet<int>{2,3};
        HashSet<int> set2 = new HashSet<int>{1,2,3,4};
        Console.WriteLine(IsSubset(set1,set2));
    }
}
 */