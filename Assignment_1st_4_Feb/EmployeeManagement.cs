/* using System;

class Employee{
    public static string CompanyName = "SS Tech Solutions";
    public static int TotalEmployees = 0;
    public readonly int Id;
    private string name;
    private string designation;
    public Employee(string name,int id,string designation){
        this.name = name;
        this.Id = id;
        this.designation = designation;
        TotalEmployees++;
    }
    public static void DisplayTotalEmployees(){
        Console.WriteLine($"Total Employees: {TotalEmployees}");
    }
    public void DisplayEmployeeDetails(){
        if(this is Employee){
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Designation: {designation}");
        }
        else{
            Console.WriteLine("This object is not an instance of the Employee class.");
        }
    }
}

class Program{
    public static void Main(string[] args){
		Console.WriteLine($"CompanyName: {Employee.CompanyName}");
        Employee emp1 = new Employee("Ram",101,"Software Engineer");
        Employee emp2 = new Employee("Shyam",102,"Project Manager");
        Console.WriteLine("\nEmployee 1 Details:");
        emp1.DisplayEmployeeDetails();
        Console.WriteLine("\nEmployee 2 Details:");
        emp2.DisplayEmployeeDetails();
        Employee.DisplayTotalEmployees();
    }
}
 */