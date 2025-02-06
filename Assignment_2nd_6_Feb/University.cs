/* using System;

public class Student{
    private string name;
    private List<Course> enrolledCourses;
    public Student(string name){
        this.name = name;
        enrolledCourses = new List<Course>();
    }
    public void EnrollInCourse(Course course){
        this.enrolledCourses.Add(course);
        Console.WriteLine($"{name} enrolled in {course.GetName()}.");
    }
    public string GetName(){
        return name;
    }
    public List<Course> GetEnrolledCourses(){
        return enrolledCourses;
    }
}

public class Professor{
    private string name;
    private List<Course> taughtCourses;
    public Professor(string name){
        this.name = name;
        taughtCourses = new List<Course>();
    }
    public void AssignCourse(Course course){
        this.taughtCourses.Add(course);
        Console.WriteLine($"{name} assigned to teach {course.GetName()}.");
    }
    public string GetName(){
        return name;
    }
    public List<Course> GetTaughtCourses(){
        return taughtCourses;
    }
}

public class Course{
    private string name;
    public Course(string name){
        this.name = name;
    }
    public string GetName(){
        return name;
    }
}

public class Program{
    public static void Main(string[] args){
        Student student = new Student("Shubham");
        Professor professor = new Professor("Dr. Saurav");
        Course course = new Course("Computer Science 8085");
        student.EnrollInCourse(course);
        professor.AssignCourse(course);
    }
}
 */