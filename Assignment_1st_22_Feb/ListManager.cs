//using System;
//using System.Collections.Generic;

//public class ListManager
//{
//    public void AddElement(List<int> list, int element) => list.Add(element);
//    public void RemoveElement(List<int> list, int element) => list.Remove(element);
//    public int GetSize(List<int> list) => list.Count;
//}

//class Program
//{
//    static void Main()
//    {
//        List<int> numbers = new List<int> {1, 2, 3};
//        ListManager manager = new ListManager();
//        manager.AddElement(numbers, 4);
//        Console.WriteLine("List size: " + manager.GetSize(numbers)); // 4
//        manager.RemoveElement(numbers, 2);
//        Console.WriteLine("List size after removal: " + manager.GetSize(numbers)); // 3
//    }
//}
