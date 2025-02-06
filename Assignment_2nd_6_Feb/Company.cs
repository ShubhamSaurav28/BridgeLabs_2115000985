/* using System;

public class Company{
    private List<Department> departments;
    public Company(){
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
    private List<Employee> employees;
    public Department(string departmentName){
        this.departmentName = departmentName;
        employees = new List<Employee>();
    }
    public void AddEmployee(Employee employee){
        this.employees.Add(employee);
    }
    public string GetDepartmentName(){
        return departmentName;
    }
    public List<Employee> GetEmployees(){
        return employees;
    }
}

public class Employee{
    private string name;
    public Employee(string name){
        this.name = name;
    }
    public string GetName(){
        return name;
    }
}

public class Program{
    public static void Main(string[] args){
        Company company1 = new Company();
		Company company2 = new Company();
		Department department1 = new Department("IT");
		Department department2 = new Department("HR");
		Department department3 = new Department("Logistics");
		Department department4 = new Department("Tech");
		Department department5 = new Department("Goods");
		Department department6 = new Department("Sales");
        Employee employee1 = new Employee("Aarav");
		Employee employee2 = new Employee("Ishita");
		Employee employee3 = new Employee("Rohan");
		Employee employee4 = new Employee("Priya");
		Employee employee5 = new Employee("Aditi");
		Employee employee6 = new Employee("Siddharth");
		Employee employee7 = new Employee("Neha");
		Employee employee8 = new Employee("Karthik");
		Employee employee9 = new Employee("Ananya");
		Employee employee10 = new Employee("Vikram");
        department1.AddEmployee(employee1);
		department2.AddEmployee(employee2);
		department3.AddEmployee(employee3);
		department4.AddEmployee(employee4);
		department5.AddEmployee(employee5);
		department6.AddEmployee(employee6);
		department1.AddEmployee(employee7);
		department2.AddEmployee(employee8);
		department3.AddEmployee(employee9);
		department4.AddEmployee(employee10);
        company1.AddDepartment(department1);
		company1.AddDepartment(department2);
		company2.AddDepartment(department3);
		company2.AddDepartment(department4);
		company1.AddDepartment(department5);
		company2.AddDepartment(department6);
        foreach(var dept in company1.GetDepartments()){
            Console.WriteLine($"Department: {dept.GetDepartmentName()}");
            foreach(var employee in dept.GetEmployees()){
                Console.WriteLine($"Employee: {employee.GetName()}");
            }
        }
		Console.WriteLine();
        foreach (var dept in company2.GetDepartments()){
            Console.WriteLine($"Department: {dept.GetDepartmentName()}");
            foreach (var employee in dept.GetEmployees()){
                Console.WriteLine($"Employee: {employee.GetName()}");
            }
        }
    }
}
 */