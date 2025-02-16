/* using System;
using System.Text;

class Program{
    public static string ReverseString(string input){
        StringBuilder sb = new StringBuilder(input);
        int left = 0;
		int right = sb.Length-1;
        while(left<right){
            char temp = sb[left];
            sb[left] = sb[right];
            sb[right] = temp;
            left++;
            right--;
        }
        return sb.ToString();
    }
    public static void Main(){
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        string reversed = ReverseString(input);
        Console.WriteLine($"Reversed String: {reversed}");
    }
}
 */