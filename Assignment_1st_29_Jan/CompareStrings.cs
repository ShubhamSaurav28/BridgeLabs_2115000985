/* using System;

class CompareStrings{
    public static void Main(){
        Console.Write("Enter String 1: ");
        string str1 = Console.ReadLine();
        Console.Write("Enter String 2: ");
        string str2 = Console.ReadLine();
        CompareStrings(str1,str2);
    }
    public static void CompareStrings(string str1,string str2){
        int minLength = str1.Length<str2.Length?str1.Length:str2.Length;
        for(int i=0;i<minLength;i++){
            if(str1[i]<str2[i]){
                Console.WriteLine($"{str1} comes before {str2} lexicographically.");
                return;
            }
            else if(str1[i]>str2[i]){
                Console.WriteLine($"{str2} comes before {str1} lexicographically.");
                return;
            }
        }
        if(str1.Length==str2.Length){
		    Console.WriteLine("Both strings are equal.");
		}
        else if(str1.Length<str2.Length){
		    Console.WriteLine($"{str1} comes before {str2} lexicographically.");
		}
        else{
		    Console.WriteLine($"{str2} comes before {str1} lexicographically.");
		}
    }
} */