/* using System;
using System.Collections;
using System.Collections.Generic;

class Program{
    public static void ReverseArrayList(ArrayList list){
        int left = 0;
		int right = list.Count-1;
        while(left<right){
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }
    public static void ReverseLinkedList(LinkedList<int> list){
        LinkedList<int> reversedList = new LinkedList<int>();
        foreach(var item in list){
            reversedList.AddFirst(item);
		}
        Console.WriteLine(string.Join(", ",reversedList));
    }
    public static void Main(){
        ArrayList arrList = new ArrayList{1,2,3,4,5};
        ReverseArrayList(arrList);
        Console.WriteLine(string.Join(", ",arrList));
        LinkedList<int> linkedList = new LinkedList<int>(new int[]{1,2,3,4,5});
        ReverseLinkedList(linkedList);
    }
}
 */