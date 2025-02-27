//using System;
//using System.IO;

//public class FileProcessor
//{
//    public void WriteToFile(string filename, string content)
//    {
//        File.WriteAllText(filename, content);
//    }

//    public string ReadFromFile(string filename)
//    {
//        if (!File.Exists(filename)) throw new FileNotFoundException();
//        return File.ReadAllText(filename);
//    }

//    public static void Main(string[] args)
//    {
//        string testFile = "test.txt";
//        FileProcessor fileProcessor = new FileProcessor();
        
//        fileProcessor.WriteToFile(testFile, "Hello, File Handling!");
//        Console.WriteLine("File content: " + fileProcessor.ReadFromFile(testFile));
//    }
//}
