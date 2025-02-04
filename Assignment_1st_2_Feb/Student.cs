//using System;

//public class Student{
//    public int RollNumber;
//    protected string Name;
//    private double CGPA;
//    public Student(int rollNumber,string name,double CGPA){
//        RollNumber = rollNumber;
//        Name = name;
//        this.CGPA = CGPA;
//    }
//    public double GetCGPA(){
//        return CGPA;
//    }
//    public void SetCGPA(double CGPA){
//        if(CGPA>=0 && CGPA<=10){
//            this.CGPA = CGPA;
//        }
//    }
//}

//public class PostgraduateStudent:Student{
//    public PostgraduateStudent(int rollNumber,string name,double CGPA):base(rollNumber,name,CGPA){
//    }   
//    public void DisplayDetails(){
//        Console.WriteLine($"Roll Number: {RollNumber}, Name: {Name}, CGPA: {GetCGPA()}");
//    }
//}

//public class Program{
//    public static void Main(string[] args){
//        PostgraduateStudent student1 = new PostgraduateStudent(1,"Shubham", 9.5);
//        student1.DisplayDetails();
//        student1.SetCGPA(9.2);
//        Console.WriteLine($"Updated CGPA: {student1.GetCGPA()}");
//    }
//}
