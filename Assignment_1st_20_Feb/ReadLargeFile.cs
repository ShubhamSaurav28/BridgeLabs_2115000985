/* using System;
using System.IO;

class ReadLargeFile{
    public static void Main(){
        string filePath = "largefile.txt";
        try{
            using(StreamReader reader = new StreamReader(filePath)){
                string line;
                while((line = reader.ReadLine())!=null){
                    if(line.ToLower().Contains("error")){
                        Console.WriteLine(line);
					}
                }
            }
        }
        catch(Exception ex){
            Console.WriteLine("Error: "+ex.Message);
        }
    }
}
 */