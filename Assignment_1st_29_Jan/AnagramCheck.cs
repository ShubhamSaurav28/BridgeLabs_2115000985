/* using System;

class AnagramCheck{
    public static void Main(){
        Console.Write("Enter String 1: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter String 2: ");
        string str2 = Console.ReadLine();
        Console.WriteLine(AreAnagrams(str1,str2)?"Strings are anagrams":"Strings are not anagrams");
    }
    public static bool AreAnagrams(string str1,string str2){
        if(str1.Length!=str2.Length){
			return false;
		}
        int[] freq = new int[256];
        for(int i=0;i<str1.Length;i++){
            freq[str1[i]]++;
            freq[str2[i]]--;
        }
        for(int i=0;i<256;i++){
            if(freq[i]!=0){
                return false;
			}
        }
        return true;
    }
} */