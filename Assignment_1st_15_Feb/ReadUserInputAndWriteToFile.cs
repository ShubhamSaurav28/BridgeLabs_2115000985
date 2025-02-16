/* using System;
using System.IO;

class Program{
    public static void Main(){
        string filePath = "UserInput.txt";
        try{
            using(StreamWriter writer = new StreamWriter(filePath,true)){
                Console.WriteLine("Enter text to write to the file (type 'exit' to stop):");
                while(true){
                    string input = Console.ReadLine();
                    if(input.ToLower()=="exit"){
						break;
					}
                    writer.WriteLine(input);
                }
            }
            Console.WriteLine($"User input successfully written to {filePath}.");
        }
        catch(Exception ex){
            Console.WriteLine($"Error writing to file: {ex.Message}");
        }
    }
}
 */