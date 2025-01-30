/* using System;

class  LongestWord{
	public static void Main(string[] args){
		string str = Console.ReadLine();
		string[] words = str.Trim().Split(" ");
		string result = "";
		for(int i=0;i<words.Length;i++){
			if(words[i].Length>result.Length){
				result = words[i];
			}
		}
		Console.WriteLine($"Result : {result}");
	}
} */