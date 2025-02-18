/* using System;
using System.Collections.Generic;

abstract class CourseType{
    public string Name{get;set;}
    public CourseType(string name) => Name = name;
}

class ExamCourse:CourseType{ 
	public ExamCourse(string name):base(name){} 
}
class AssignmentCourse:CourseType{
	public AssignmentCourse(string name):base(name){}
}

class Course<T> where T:CourseType{
    private List<T> courses = new List<T>();
    public void AddCourse(T course) => courses.Add(course);
    public void DisplayCourses(){
        foreach(var course in courses){
            Console.WriteLine(course.Name);
		}
    }
}

class Program{
    public static void Main(){
        Course<ExamCourse> examCourseList = new Course<ExamCourse>();
        examCourseList.AddCourse(new ExamCourse("Data Structures"));
        examCourseList.DisplayCourses();
    }
} */