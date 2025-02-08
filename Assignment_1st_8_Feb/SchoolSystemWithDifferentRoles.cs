/* using System;

class Person{
    protected string name;
    protected int age;
    public Person(string name, int age){
        this.name = name;
        this.age = age;
    }
    public virtual void DisplayRole(){
        Console.WriteLine($"Name: {this.name}, Age: {this.age}");
    }
}

class Student:Person{
    private string grade;
    public Student(string name,int age,string grade):base(name,age){
        this.grade = grade;
    }
    public override void DisplayRole(){
        Console.WriteLine($"Student Name: {this.name}, Age: {this.age}, Grade: {this.grade}");
    }
}

class Teacher:Person{
    private string subject;
    public Teacher(string name,int age,string subject):base(name,age){
        this.subject = subject;
    }
    public override void DisplayRole(){
        Console.WriteLine($"Teacher Name: {this.name}, Age: {this.age}, Subject: {this.subject}");
    }
}

class Staff:Person{
    private string department;
    public Staff(string name,int age,string department):base(name,age){
        this.department = department;
    }
    public override void DisplayRole(){
        Console.WriteLine($"Staff Name: {this.name}, Age: {this.age}, Department: {this.department}");
    }
}

class Program{
    public static void Main(){
        Person teacher = new Teacher("Shubham",20,"Mathematics");
        Person student = new Student("Sparsh",16,"10th Grade");
        Person staff = new Staff("Rohan",45,"Library");
        teacher.DisplayRole();
        student.DisplayRole();
        staff.DisplayRole();
    }
}
 */