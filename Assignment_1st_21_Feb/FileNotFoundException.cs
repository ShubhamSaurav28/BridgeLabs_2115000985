/* using System;
using System.IO;

class Program{
    public static void Main(){
        string filePath = "data.txt";
        try{
            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Contents:\n"+content);
        }
        catch(IOException){
            Console.WriteLine("File not found");
        }
    }
} */