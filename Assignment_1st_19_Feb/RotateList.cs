/* using System;
using System.Collections.Generic;

class Program{
    public static List<int> RotateList(List<int> list,int positions){
        int n = list.Count;
        positions %= n;
        List<int> rotated = new List<int>();
        rotated.AddRange(list.GetRange(positions,n-positions));
        rotated.AddRange(list.GetRange(0,positions));
        return rotated;
    }
    public static void Main(){
        List<int> numbers = new List<int>{10,20,30,40,50};
        int rotateBy = 2;
        var result = RotateList(numbers,rotateBy);
        Console.WriteLine(string.Join(", ",result));
    }
}
 */