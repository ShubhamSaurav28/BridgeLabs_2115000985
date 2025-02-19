/* using System;
using System.Collections.Generic;

class Program{
    public static List<int> RemoveDuplicates(List<int> list){
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();
        foreach(var item in list){
            if(!seen.Contains(item)){
                seen.Add(item);
                result.Add(item);
            }
        }
        return result;
    }
    public static void Main(){
        List<int> numbers = new List<int>{3,1,2,2,3,4};
        var result = RemoveDuplicates(numbers);
        Console.WriteLine(string.Join(", ",result));
    }
}
 */