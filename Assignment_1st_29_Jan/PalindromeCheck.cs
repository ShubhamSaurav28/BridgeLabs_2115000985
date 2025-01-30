/* using System;

class  PalindromeCheck{
	public static void Main(string[] args){
		string str = Console.ReadLine();
		int i = 0;
		int j = str.Length-1;
		int flag = 0;
		while(i<j){
			if(str[i]!=str[j]){
				flag = 1;
				break;
			}
			i++;
			j--;
		}
		if(flag==0){
			Console.WriteLine($"String is Palindrome");
		}
		else{
			Console.WriteLine($"String is not a Palindrome");
		}
	}
} */