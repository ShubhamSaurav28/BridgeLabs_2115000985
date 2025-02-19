/* using System;
using System.Collections.Generic;

class Program{
    public static string FindNthFromEnd(LinkedList<string> list,int n){
        var fast = list.First;
        var slow = list.First;
        for(int i=0;i<n;i++){
            if(fast==null){
				return "N is too large";
			}
            fast = fast.Next;
        }
        while(fast!=null){
            fast = fast.Next;
            slow = slow.Next;
        }
        return slow.Value;
    }
    public static void Main(){
        LinkedList<string> list = new LinkedList<string>(new string[]{"A","B","C","D","E"});
        int n = 2;
        Console.WriteLine(FindNthFromEnd(list,n));
    }
}
 */