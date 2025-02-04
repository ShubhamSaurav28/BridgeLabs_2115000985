/* using System;

class Student{
    public static string UniversityName = "Global University";
    public static int TotalStudents = 0;
    public readonly int RollNumber;
    private string name;
    private string grade;
    public Student(string name,int rollNumber,string grade){
        this.name = name;
        this.RollNumber = rollNumber;
        this.grade = grade;
        TotalStudents++;
    }
    public static void DisplayTotalStudents(){
        Console.WriteLine($"Total Students Enrolled: {TotalStudents}");
    }
    public void DisplayStudentDetails(){
        if(this is Student){
            Console.WriteLine($"University: {UniversityName}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Roll Number: {RollNumber}");
            Console.WriteLine($"Grade: {grade}");
        }
        else{
            Console.WriteLine("This object is not an instance of the Student class.");
        }
    }
    public void UpdateGrade(string newGrade){
        if(this is Student){
            grade = newGrade;
            Console.WriteLine($"Grade updated to: {grade}");
        }
        else{
            Console.WriteLine("This object is not an instance of the Student class.");
        }
    }
}

class Program{
    public static void Main(string[] args){
        Student.DisplayTotalStudents();
        Student student1 = new Student("Shubham",101,"A");
        Student student2 = new Student("Sparsh",102,"B");
        Console.WriteLine("\nStudent 1 Details:");
        student1.DisplayStudentDetails();
        Console.WriteLine("\nStudent 2 Details:");
        student2.DisplayStudentDetails();
        student1.UpdateGrade("A+");
        student2.UpdateGrade("B+");
        Console.WriteLine("\nUpdated Student Details:");
        student1.DisplayStudentDetails();
        student2.DisplayStudentDetails();
        Student.DisplayTotalStudents();
    }
}
 */