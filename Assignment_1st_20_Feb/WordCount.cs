/* using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class CountWordsInFile{
    public static void Main(){
        string filePath = "sample.txt";   
        try{
            if(!File.Exists(filePath)){
                Console.WriteLine("File does not exist.");
                return;
            }
            Dictionary<string,int> wordCount = new Dictionary<string,int>();
            using(StreamReader reader = new StreamReader(filePath)){
                string line;
                while((line = reader.ReadLine())!=null){
                    string[] words = line.ToLower().Split(new char[]{' ','.',',','!','?',';',':','"','\''},StringSplitOptions.RemoveEmptyEntries);
                    foreach(string word in words){
                        if(wordCount.ContainsKey(word)){
                            wordCount[word]++;
						}
                        else{
                            wordCount[word] = 1;
						}
                    }
                }
            }
            var sortedWords = wordCount.OrderByDescending(w => w.Value).Take(5);
            Console.WriteLine("Top 5 most frequently occurring words:");
            foreach(var item in sortedWords){
                Console.WriteLine($"{item.Key}: {item.Value} times");
            }
        }
        catch(IOException ex){
            Console.WriteLine("An error occurred while reading the file: "+ex.Message);
        }
        catch(Exception ex){
            Console.WriteLine("Unexpected error: "+ex.Message);
        }
    }
}
 */