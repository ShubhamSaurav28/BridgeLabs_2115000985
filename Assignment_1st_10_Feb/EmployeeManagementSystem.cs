/* using System;

interface IDepartment{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
}

abstract class Employee{
    protected int employeeId;
    protected string name;
    protected double baseSalary;
    public Employee(int employeeId,string name,double baseSalary){
        this.employeeId = employeeId;
        this.name = name;
        this.baseSalary = baseSalary;
    }
    public abstract double CalculateSalary();
    public void DisplayDetails(){
        Console.WriteLine($"ID: {this.employeeId}, Name: {this.name}, Salary: {this.CalculateSalary()}");
    }
}

class FullTimeEmployee:Employee,IDepartment{
    private double fixedSalary;
	private string department;
    public FullTimeEmployee(int employeeId,string name,double baseSalary,double fixedSalary):base(employeeId,name,baseSalary){
        this.fixedSalary = fixedSalary;
    }
    public override double CalculateSalary(){
        return this.fixedSalary;
    }
	public void AssignDepartment(string departmentName){
        this.department = departmentName;
    }
    public string GetDepartmentDetails(){
        return $"FullTime Employee Department: {this.department}";
    }
}

class PartTimeEmployee:Employee,IDepartment{
    private int hoursWorked;
    private double hourlyRate;
	private string department;
    public PartTimeEmployee(int employeeId,string name,double baseSalary,int hoursWorked,double hourlyRate):base(employeeId,name,baseSalary){
        this.hoursWorked = hoursWorked;
        this.hourlyRate = hourlyRate;
    }
    public override double CalculateSalary(){
        return this.hoursWorked*this.hourlyRate;
    }
	public void AssignDepartment(string departmentName){
        this.department = departmentName;
    }
    public string GetDepartmentDetails(){
        return $"FullTime Employee Department: {this.department}";
    }
}

class Program{
    public static void Main(string[] args){
        FullTimeEmployee emp1 = new FullTimeEmployee(1,"Rajesh",50000,75000);
        PartTimeEmployee emp2 = new PartTimeEmployee(2,"Priya",30000,20,600);
        emp1.AssignDepartment("Development");
        emp2.AssignDepartment("Support");
        emp1.DisplayDetails();
        Console.WriteLine(emp1.GetDepartmentDetails());
        emp2.DisplayDetails();
        Console.WriteLine(emp2.GetDepartmentDetails());
    }
}
 */