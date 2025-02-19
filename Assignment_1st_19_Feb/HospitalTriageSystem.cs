/* using System;
using System.Collections.Generic;

class Patient:IComparable<Patient>{
    public string Name{get;set;}
    public int Severity{get;set;}
    public Patient(string name,int severity){
        Name = name;
        Severity = severity;
    }
    public int CompareTo(Patient other) => other.Severity.CompareTo(this.Severity);
}

class Program{
    public static void Main(){
        PriorityQueue<Patient> pq = new PriorityQueue<Patient>(new List<Patient>{
            new Patient("John",3),
            new Patient("Alice",5),
            new Patient("Bob",2)
        });
        while(pq.Count>0){
            Console.WriteLine(pq.Dequeue().Name);
		}
    }
}
 */