/* using System;

interface IWorker{
    void PerformDuties();
}

class Person{
    protected string name;
    protected int id;
    public Person(string name,int id){
        this.name = name;
        this.id = id;
    }
    public void ShowDetails(){
        Console.WriteLine($"Name: {this.name}, ID: {this.id}");
    }
}

class Waiter:Person,IWorker{
    private string assignedTable;
    public Waiter(string name,int id,string assignedTable):base(name,id){
        this.assignedTable = assignedTable;
    }
    public void PerformDuties(){
        Console.WriteLine($"{this.name} (Waiter) is attending {this.assignedTable}.");
    }
}

class Chef:Person,IWorker{
    private string specialty;
    public Chef(string name,int id,string specialty):base(name,id){
        this.specialty = specialty;
    }
    public void PerformDuties(){
        Console.WriteLine($"{this.name} (Chef) is making {this.specialty} dishes.");
    }
}

class Program{
    public static void Main(){
        IWorker chef = new Chef("Rahul",101,"Italian");
        IWorker waiter = new Waiter("Ankit",202,"Table 5");
        chef.PerformDuties();
        waiter.PerformDuties();
    }
}
 */