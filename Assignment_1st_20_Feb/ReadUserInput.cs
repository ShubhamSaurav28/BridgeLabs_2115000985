/* using System;
using System.IO;

class ReadUserInput{
    public static void Main(){
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your age: ");
        string age = Console.ReadLine();
        Console.Write("Enter your favorite programming language: ");
        string language = Console.ReadLine();
        string filePath = "UserInfo.txt";
        try{
            using (StreamWriter writer = new StreamWriter(filePath)){
                writer.WriteLine($"Name: {name}");
                writer.WriteLine($"Age: {age}");
                writer.WriteLine($"Favorite Language: {language}");
            }
            Console.WriteLine("User information saved.");
        }
        catch(Exception ex){
            Console.WriteLine("Error: "+ex.Message);
        }
    }
}
 */