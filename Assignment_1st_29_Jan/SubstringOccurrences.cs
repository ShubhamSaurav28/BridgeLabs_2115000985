/* using System;

class  SubstringOccurrences{
	public static void Main(string[] args){
		Console.Write("Enter the main string: ");
        string mainString = Console.ReadLine();
        Console.Write("Enter the substring to find: ");
        string subString = Console.ReadLine();
        int count = 0;
        int startIndex = 0;
        while((startIndex = mainString.IndexOf(subString, startIndex))!=-1){
            count++;
            startIndex += subString.Length;
        }
        Console.WriteLine($"Occurrences: {count}");
	}
} */