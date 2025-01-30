/* using System;

class  RemoveDuplicates{
	public static void Main(string[] args){
		string str = Console.ReadLine();
		int[] frequency = new int[256];
        string result = "";
        for(int i=0;i<str.Length;i++){
            char currentChar = str[i];
            if(frequency[currentChar]==0){
                result += currentChar;
                frequency[currentChar]++;
            }
        }
		Console.WriteLine($"Result : {result}");
	}
} */