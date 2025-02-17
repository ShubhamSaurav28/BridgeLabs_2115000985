/* using System;
using System.IO;

class Program {
    public static void Main() {
        string filePath = "largefile.txt";
        using (StreamReader reader = new StreamReader(filePath)) {
            while(reader.ReadLine()!=null){}
        }
        using (FileStream fs = new FileStream(filePath,FileMode.Open,FileAccess.Read)) {
            byte[] buffer = new byte[1024];
            while(fs.Read(buffer,0,buffer.Length)>0){}
        }
        Console.WriteLine("File read successfully.");
    }
}
 */