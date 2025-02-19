/* using System;
using System.Collections.Generic;

class Program{
    public static Dictionary<int,List<string>> InvertDictionary(Dictionary<string,int> input){
        Dictionary<int,List<string>> inverted = new Dictionary<int,List<string>>();
        foreach(var pair in input){
            if(!inverted.ContainsKey(pair.Value)){
                inverted[pair.Value] = new List<string>();
			}
            inverted[pair.Value].Add(pair.Key);
        }
        return inverted;
    }
    public static void Main(){
        Dictionary<string,int> data = new Dictionary<string,int>{{"A",1},{"B",2},{"C",1}};
        var result = InvertDictionary(data);
        foreach(var pair in result){
            Console.WriteLine($"{pair.Key}: [{string.Join(", ", pair.Value)}]");
		}
    }
}
 */