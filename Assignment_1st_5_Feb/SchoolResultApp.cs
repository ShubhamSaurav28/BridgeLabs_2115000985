/* using System;

class Subject{
    private string subjectName;
    private int marks;
    public string GetSubjectName(){
        return this.subjectName;
    }
    public void SetSubjectName(string subjectName){
        this.subjectName = subjectName;
    }
    public int GetMarks(){
        return this.marks;
    }
    public void SetMarks(int marks){
        this.marks = marks;
    }
    public Subject(string subjectName,int marks){
        this.SetSubjectName(subjectName);
        this.SetMarks(marks);
    }
}

class Student{
    private string name;
    private List<Subject> subjects;
    public string GetName(){
        return this.name;
    }
    public void SetName(string name){
        this.name = name;
    }
    public List<Subject> GetSubjects(){
        return this.subjects;
    }
    public void SetSubjects(List<Subject> subjects){
        this.subjects = subjects;
    }
    public Student(string name){
        this.SetName(name);
        this.subjects = new List<Subject>();
    }
    public void AddSubject(Subject subject){
        this.subjects.Add(subject);
    }
}

class GradeCalculator{
    public static void CalculateGrade(Student student){
        if(student.GetSubjects().Count==0){
            Console.WriteLine($"{student.GetName()} has no subjects.");
            return;
        }
        int totalMarks = student.GetSubjects().Sum(subject=>subject.GetMarks());
        double average = totalMarks/(double)student.GetSubjects().Count;
        string grade = DetermineGrade(average);
        Console.WriteLine($"Student: {student.GetName()}, Average Marks: {average:F2}, Grade: {grade}");
    }
    private static string DetermineGrade(double average){
		if(average>=90){
			return "A";
		}
		else if(average>=75){
			return "B";
		}
		else if(average>=50){
			return "C";
		}
		else{
			return "F";
		}
	}

}

class Program{
    public static void Main(string[] args){
        Student student = new Student("John");
        student.AddSubject(new Subject("Maths",90));
        student.AddSubject(new Subject("Science",85));
        Console.WriteLine("Grade Calculation Process:");
        GradeCalculator.CalculateGrade(student);
    }
}
 */