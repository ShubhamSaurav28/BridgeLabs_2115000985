/* using System;
using System.Collections.Generic;

class Program{
    public static Dictionary<string, int> GetFrequency(List<string> items){
        Dictionary<string,int> frequency = new Dictionary<string,int>();
        foreach(var item in items){
            if(frequency.ContainsKey(item)){
                frequency[item]++;
			}
            else{
                frequency[item] = 1;
			}
        }
        return frequency;
    }
    public static void Main(){
        List<string> words = new List<string>{"apple","banana","apple","orange"};
        var freq = GetFrequency(words);
        foreach(var pair in freq){
            Console.WriteLine($"{pair.Key}: {pair.Value}");
		}
    }
}
 */