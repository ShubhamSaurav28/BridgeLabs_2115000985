/* using System;
using System.IO;

class ConvertUpperToLower{
    public static void Main(){
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";
        try{
            using(StreamReader reader = new StreamReader(sourceFile))
            using(StreamWriter writer = new StreamWriter(destinationFile)){
                string line;
                while((line = reader.ReadLine())!=null){
                    writer.WriteLine(line.ToLower());
                }
            }
            Console.WriteLine("Conversion completed.");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: "+ex.Message);
        }
    }
}
 */