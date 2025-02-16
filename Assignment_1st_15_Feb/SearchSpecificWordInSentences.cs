/* using System;

class Program{
    public static string FindSentenceWithWord(string[] sentences,string targetWord){
        foreach(string sentence in sentences){
            if(sentence.Contains(targetWord,StringComparison.OrdinalIgnoreCase)){
                return sentence;
			}
        }
        return "Word not found in any sentence.";
    }
    public static void Main(){
        string[] sentences = {
            "The quick brown fox jumps over the lazy dog.",
            "C# is a powerful programming language.",
            "Data structures and algorithms are important for coding interviews.",
            "Machine learning is revolutionizing the world."
        };
        Console.Write("Enter the word to search: ");
        string word = Console.ReadLine();
        string result = FindSentenceWithWord(sentences,word);
        Console.WriteLine($"Sentence containing '{word}': {result}");
    }
}
 */