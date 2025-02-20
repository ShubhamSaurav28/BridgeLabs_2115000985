/* using System;
using System.IO;

class FileReadWrite{
    public static void Main(){
        string sourceFile = "source.txt";
        string destinationFile = "destination.txt";
        try{
            if(!File.Exists(sourceFile)){
                Console.WriteLine("Source file does not exist.");
                return;
            }
            using(FileStream fsRead = new FileStream(sourceFile,FileMode.Open,FileAccess.Read))
            using(FileStream fsWrite = new FileStream(destinationFile,FileMode.Create,FileAccess.Write)){
                fsRead.CopyTo(fsWrite);
            }

            Console.WriteLine("File copied successfully.");
        }
        catch(Exception ex){
            Console.WriteLine("Error: "+ex.Message);
        }
    }
}
 */