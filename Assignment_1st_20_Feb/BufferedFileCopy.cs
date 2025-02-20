/* using System;
using System.Diagnostics;
using System.IO;

class BufferedFileCopy{
    public static void Main(){
        string sourceFile = "largefile.bin";
        string destinationFile = "copy.bin";
        int bufferSize = 4096;
        try{
            Stopwatch stopwatch = Stopwatch.StartNew();
            using(FileStream fsRead = new FileStream(sourceFile,FileMode.Open,FileAccess.Read))
            using(FileStream fsWrite = new FileStream(destinationFile, FileMode.Create,FileAccess.Write))
            using(BufferedStream bsRead = new BufferedStream(fsRead,bufferSize))
            using(BufferedStream bsWrite = new BufferedStream(fsWrite,bufferSize)){
                bsRead.CopyTo(bsWrite);
            }
            stopwatch.Stop();
            Console.WriteLine($"Buffered copy completed in {stopwatch.ElapsedMilliseconds} ms.");
        }
        catch(Exception ex){
            Console.WriteLine("Error: "+ex.Message);
        }
    }
}
 */