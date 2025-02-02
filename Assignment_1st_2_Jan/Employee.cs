//using System;

//public class Employee{
//    public int EmployeeID;
//    protected string Department;
//    private double Salary;
//    public Employee(int employeeID,string department,double salary){
//        EmployeeID = employeeID;
//        Department = department;
//        Salary = salary;
//    }
//    public void SetSalary(double salary){
//        if(salary>0){
//            Salary = salary;
//        }
//    }
//    public double GetSalary(){
//        return Salary;
//    }
//}

//public class Manager : Employee{
//    public Manager(int employeeID,string department,double salary):base(employeeID,department,salary){
//    }
//    public void DisplayEmployeeDetails(){
//        Console.WriteLine($"Employee ID: {EmployeeID}, Department: {Department}, Salary: {GetSalary()}");
//    }
//}

//public class Program{
//    public static void Main(string[] args){
//        Manager manager1 = new Manager(1, "IT", 50000.0);
//        manager1.DisplayEmployeeDetails();
//        manager1.SetSalary(55000.0);
//        Console.WriteLine($"Updated Salary: {manager1.GetSalary()}");
//    }
//}
