/* using System;
using System.IO;

class Program{
    public static void Main(){
        string filePath = "info.txt";
        try{
            using (StreamReader reader = new StreamReader(filePath)){
                Console.WriteLine("First line: "+reader.ReadLine());
            }
        }
        catch(IOException){
            Console.WriteLine("Error reading file");
        }
    }
} */