/* using System;
using System.IO;
using System.Text;

class Program{
    public static void ReadBinaryFileAsText(string filePath){
        try{
            using (FileStream fs = new FileStream(filePath,FileMode.Open,FileAccess.Read))
            using (StreamReader reader = new StreamReader(fs,Encoding.UTF8)){
                string content = reader.ReadToEnd();
                Console.WriteLine("File Content:\n"+content);
            }
        }
        catch (Exception ex){
            Console.WriteLine($"Error reading file: {ex.Message}");
        }
    }
    public static void Main(){
        Console.Write("Enter the binary file path: ");
        string filePath = Console.ReadLine();
        ReadBinaryFileAsText(filePath);
    }
}
 */