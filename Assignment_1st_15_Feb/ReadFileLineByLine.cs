/* using System;
using System.IO;

class Program{
    public static void ReadFileLineByLine(string filePath){
        try{
            using(StreamReader reader = new StreamReader(filePath)){
                string line;
                while((line=reader.ReadLine())!=null){
                    Console.WriteLine(line);
                }
            }
        }
        catch(Exception ex){
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }
    public static void Main(){
        Console.Write("Enter file path: ");
        string filePath = Console.ReadLine();
        ReadFileLineByLine(filePath);
    }
}
 */