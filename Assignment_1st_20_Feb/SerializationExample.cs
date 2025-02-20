/* using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

[Serializable]
class Employee{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Department{get;set;}
    public double Salary{get;set;}
}

class SerializationExample{
    public static void Main(){
        List<Employee> employees = new List<Employee>{
            new Employee{Id=1,Name="Alice",Department="HR",Salary=50000},
            new Employee{Id=2,Name="Bob",Department="IT",Salary=70000}
        };
        string filePath = "employees.json";
        try{
            File.WriteAllText(filePath,JsonSerializer.Serialize(employees));
            Console.WriteLine("Employees serialized successfully.");
            string jsonData = File.ReadAllText(filePath);
            List<Employee> deserializedEmployees = JsonSerializer.Deserialize<List<Employee>>(jsonData);
            Console.WriteLine("Deserialized Employees:");
            foreach(var emp in deserializedEmployees){
                Console.WriteLine($"{emp.Id} - {emp.Name} - {emp.Department} - {emp.Salary}");
			}
        }
        catch(Exception ex){
            Console.WriteLine("Error: "+ex.Message);
        }
    }
}
 */