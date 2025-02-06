/* using System;
using System.Collections.Generic;

public class University{
    private List<Department> departments;
    public University(){
        departments = new List<Department>();
    }
    public void AddDepartment(Department department){
        this.departments.Add(department);
    }
    public List<Department> GetDepartments(){
        return departments;
    }
}

public class Department{
    private string departmentName;
    private List<Faculty> faculties;
    public Department(string departmentName){
        this.departmentName = departmentName;
        faculties = new List<Faculty>();
    }
    public void AddFaculty(Faculty faculty){
        this.faculties.Add(faculty);
    }
    public string GetDepartmentName(){
        return departmentName;
    }
    public List<Faculty> GetFaculties(){
        return faculties;
    }
}

public class Faculty{
    private string name;
    public Faculty(string name){
        this.name = name;
    }
    public string GetName(){
        return name;
    }
}
public class Program{
    public static void Main(string[] args){
        University university = new University();
        Department department1 = new Department("Computer Science");
        Department department2 = new Department("Electrical Engineering");
        Faculty faculty1 = new Faculty("Dr. Aarav Sharma");
        Faculty faculty2 = new Faculty("Dr. Ishita Mehta");
        Faculty faculty3 = new Faculty("Dr. Rohan Patel");
        Faculty faculty4 = new Faculty("Dr. Priya Kapoor");
        department1.AddFaculty(faculty1);
        department1.AddFaculty(faculty2);
        department2.AddFaculty(faculty3);
        department2.AddFaculty(faculty4);
        university.AddDepartment(department1);
        university.AddDepartment(department2);
        foreach(var dept in university.GetDepartments()){
            Console.WriteLine($"Department: {dept.GetDepartmentName()}");
            foreach(var faculty in dept.GetFaculties()){
                Console.WriteLine($"Faculty: {faculty.GetName()}");
            }
        }
    }
}
 */