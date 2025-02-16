/* using System;
using System.IO;

class Program{
    public static int CountWordOccurrences(string filePath,string targetWord){
        int count = 0;
        try{
            using(StreamReader reader = new StreamReader(filePath)){
                string line;
                while((line = reader.ReadLine())!=null){
                    string[] words = line.Split(new char[] {' ','.',',','!','?',';',':','-','\t'},StringSplitOptions.RemoveEmptyEntries);
                    foreach(string word in words){
                        if(word.Equals(targetWord,StringComparison.OrdinalIgnoreCase)){
                            count++;
                        }
                    }
                }
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
        return count;
    }
    public static void Main(){
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();
        Console.Write("Enter the word to count: ");
        string targetWord = Console.ReadLine();
        int occurrences = CountWordOccurrences(filePath,targetWord);
        Console.WriteLine($"The word '{targetWord}' appears {occurrences} times in the file.");
    }
}
 */