/* using System;
using System.Collections.Generic;

class Policy{
    public string PolicyNumber{get;set;}
    public DateTime ExpiryDate{get;set;}
    public string CoverageType{get;set;}
    public Policy(string number,DateTime expiry,string type){
        PolicyNumber = number;
        ExpiryDate = expiry;
        CoverageType = type;
    }
}

class Program{
    public static void Main(){
        HashSet<string> uniquePolicies = new HashSet<string>();
        SortedSet<Policy> sortedPolicies = new SortedSet<Policy>(Comparer<Policy>.Create((x,y) => x.ExpiryDate.CompareTo(y.ExpiryDate)));
        Policy p1 = new Policy("P123",DateTime.Now.AddDays(10),"Health");
        Policy p2 = new Policy("P456",DateTime.Now.AddDays(5),"Car");
        Policy p3 = new Policy("P789",DateTime.Now.AddDays(25),"Life");
        uniquePolicies.Add(p1.PolicyNumber);
        uniquePolicies.Add(p2.PolicyNumber);
        sortedPolicies.Add(p1);
        sortedPolicies.Add(p2);
        sortedPolicies.Add(p3);
        Console.WriteLine("Policies expiring soon:");
        foreach(var policy in sortedPolicies){
            if((policy.ExpiryDate-DateTime.Now).Days <= 30){
                Console.WriteLine($"{policy.PolicyNumber} - {policy.CoverageType}");
			}
        }
    }
}
 */