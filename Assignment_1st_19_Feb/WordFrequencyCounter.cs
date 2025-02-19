/* using System;
using System.Collections.Generic;
using System.Linq;

class Program{
    public static Dictionary<string, int> CountWordFrequency(string text){
        string[] words = text.ToLower().Split(new char[]{' ',',','!','?'}, StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string,int> wordCount = new Dictionary<string,int>();
        foreach(var word in words){
            if(wordCount.ContainsKey(word)){
                wordCount[word]++;
			}
            else{
                wordCount[word] = 1;
			}
        }
        return wordCount;
    }

    public static void Main(){
        string text = "Hello world, hello Java!";
        var result = CountWordFrequency(text);
        foreach(var pair in result){
            Console.WriteLine($"{pair.Key}: {pair.Value}");
		}
    }
}
 */