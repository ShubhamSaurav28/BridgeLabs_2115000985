/* using System;

class RemoveSpecificCharacter{
    public static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.Write("Enter a character to remove: ");
        char charToRemove = Console.ReadKey().KeyChar;
        Console.WriteLine("\nModified String: "+RemoveCharacter(input,charToRemove));
    }
    public static string RemoveCharacter(string input,char charToRemove){
        char[] result = new char[input.Length];
        int index = 0;
        for(int i=0;i<input.Length;i++){
            if(input[i]!=charToRemove){
                result[index++] = input[i];
            }
        }
        return new string(result,0,index);
    }
} */