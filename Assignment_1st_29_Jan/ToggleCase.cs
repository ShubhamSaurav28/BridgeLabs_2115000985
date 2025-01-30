/* using System;

class ToggleCase{
    public static void Main(){
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        Console.WriteLine("Toggled Case: " + ToggleCase(str));
    }
    public static string ToggleCase(string str){
        char[] result = new char[str.Length];
        for (int i=0;i<str.Length;i++){
            char c = str[i];
            if(c>='A' && c<='Z'){
                result[i] = (char)(c+32);
			}
            else if (c >= 'a' && c <= 'z'){
                result[i] = (char)(c-32);
			}
            else{
                result[i] = c;
			}
        }
        return new string(result);
    }
} */