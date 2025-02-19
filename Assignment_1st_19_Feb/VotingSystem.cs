/* using System;
using System.Collections.Generic;

class Program{
    public static void Main(){
        Dictionary<string,int> votes = new Dictionary<string,int>();
        SortedDictionary<string,int> sortedVotes = new SortedDictionary<string,int>();
        votes["Alice"] = 3;
        votes["Bob"] = 5;
        votes["Charlie"] = 2;
        foreach(var v in votes){
            sortedVotes[v.Key] = v.Value;
		}
        Console.WriteLine("Sorted Voting Results:");
        foreach(var pair in sortedVotes){
            Console.WriteLine($"{pair.Key}: {pair.Value} votes");
		}
    }
}
 */