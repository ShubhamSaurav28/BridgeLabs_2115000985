/* using System;

class Employee{
    protected string name;
    protected int id;
    protected double salary;
    public Employee(string name,int id,double salary){
        this.name = name;
        this.id = id;
        this.salary = salary;
    }
    public virtual void DisplayDetails(){
        Console.WriteLine($"Name: {this.name}, ID: {this.id}, Salary: {this.salary}");
    }
}

class Manager:Employee{
    private int teamSize;
    public Manager(string name,int id,double salary,int teamSize):base(name,id,salary){
        this.teamSize = teamSize;
    }
    public override void DisplayDetails(){
        Console.WriteLine($"Manager :- Name: {this.name}, ID: {this.id}, Salary: {this.salary}, Team Size: {this.teamSize}");
    }
}

class Developer:Employee{
    private string programmingLanguage;
    public Developer(string name,int id,double salary,string programmingLanguage):base(name,id,salary){
        this.programmingLanguage = programmingLanguage;
    }
    public override void DisplayDetails(){
        Console.WriteLine($"Developer :- Name: {this.name}, ID: {this.id}, Salary: {this.salary}, Language: {this.programmingLanguage}");
    }
}

class Intern:Employee{
    private string internshipDuration;
    public Intern(string name,int id,double salary,string internshipDuration):base(name,id,salary){
        this.internshipDuration = internshipDuration;
    }
    public override void DisplayDetails(){
        Console.WriteLine($"Intern :- Name: {this.name}, ID: {this.id}, Salary: {this.salary}, Duration: {this.internshipDuration}");
    }
}

class Program{
    public static void Main(){
        Employee manager = new Manager("Mohan",101,90000,5);
        Employee developer = new Developer("Sohan",102,75000,"C#");
        Employee intern = new Intern("Rohan",103,20000,"3 Months");
        manager.DisplayDetails();
        developer.DisplayDetails();
        intern.DisplayDetails();
    }
}
 */