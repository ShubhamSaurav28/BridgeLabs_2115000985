/* using System;

public class School{
    private List<Student> students;
    public School(){
        students = new List<Student>();
    }
    public void AddStudent(Student student){
        this.students.Add(student);
    }
    public List<Student> GetStudents(){
        return students;
    }
}

public class Student{
    private string name;
    private List<Course> courses;
    public Student(string name){
        this.name = name;
        courses = new List<Course>();
    }
    public void EnrollInCourse(Course course){
        this.courses.Add(course);
    }
    public string GetName(){
        return name;
    }
    public List<Course> GetCourses(){
        return courses;
    }
}

public class Course{
    private string courseName;
    public Course(string courseName){
        this.courseName = courseName;
    }
    public string GetCourseName(){
        return courseName;
    }
}

public class Program{
    public static void Main(string[] args){
        School school = new School();
        Student student1 = new Student("Aarav");
        Student student2 = new Student("Ishita");
        Student student3 = new Student("Rohan");
        Student student4 = new Student("Priya");
        Student student5 = new Student("Aditi");
        Course course1 = new Course("Math");
        Course course2 = new Course("Science");
        Course course3 = new Course("English");
        Course course4 = new Course("History");
        student1.EnrollInCourse(course1);
        student1.EnrollInCourse(course2);
        student2.EnrollInCourse(course3);
        student2.EnrollInCourse(course4);
        student3.EnrollInCourse(course1);
        student4.EnrollInCourse(course2);
        student5.EnrollInCourse(course3);
        school.AddStudent(student1);
        school.AddStudent(student2);
        school.AddStudent(student3);
        school.AddStudent(student4);
        school.AddStudent(student5);
        foreach(var studentInSchool in school.GetStudents()){
            Console.WriteLine($"Student: {studentInSchool.GetName()}");
            foreach(var course in studentInSchool.GetCourses()){
                Console.WriteLine($"- Enrolled in: {course.GetCourseName()}");
            }
        }
    }
}
  */