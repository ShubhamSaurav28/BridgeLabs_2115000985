/* using System;
using System.Collections.Generic;

class Program{
    public static void Main(){
        Dictionary<int,double> accountBalances = new Dictionary<int,double>{{1001,5000.0},{1002,3000.0},{1003,7000.0}};
        Queue<int> withdrawalQueue = new Queue<int>();
        withdrawalQueue.Enqueue(1002);
        withdrawalQueue.Enqueue(1001);
        Console.WriteLine("Processing Withdrawals:");
        while(withdrawalQueue.Count>0){
            int account = withdrawalQueue.Dequeue();
            Console.WriteLine($"Processing withdrawal for Account {account}");
        }
    }
}
 */