/* using System;

class Program{
    public static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Most Frequent Character: "+MostFrequentCharacter(input));
    }
    public static char MostFrequentCharacter(string input){
        int[] freq = new int[256];
        for(int i=0;i<input.Length;i++){
            freq[input[i]]++;
        }
        int maxCount = 0;
        char mostFrequentChar = ' ';
        for(int i=0;i<256;i++){
            if(freq[i]>maxCount){
                maxCount = freq[i];
                mostFrequentChar = (char)i;
            }
        }
        return mostFrequentChar;
    }
} */