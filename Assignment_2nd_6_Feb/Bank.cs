/* using System;

public class Bank{
    private List<Customer> customers;
    public Bank(){
        customers = new List<Customer>();
    }
    public void AddCustomer(Customer customer){
        this.customers.Add(customer);
    }
    public List<Customer> GetCustomers(){
        return customers;
    }
}

public class Customer{
    private string name;
    private double balance;
    public Customer(string name){
        this.name = name;
    }
    public void OpenAccount(double initialBalance){
        this.balance = initialBalance;
        Console.WriteLine($"{name} opened an account with balance {balance:C}.");
    }
    public string GetName(){
        return name;
    }
    public double GetBalance(){
        return balance;
    }
}

public class Program{
    public static void Main(string[] args){
        Bank bank1 = new Bank();
		Bank bank2 = new Bank();
        Customer customer1 = new Customer("Ram");
		Customer customer2 = new Customer("Mohan");
		Customer customer3 = new Customer("Vatsal");
		Customer customer4 = new Customer("Sparsh");
        customer1.OpenAccount(1000);
		customer2.OpenAccount(1500);
		customer3.OpenAccount(1200);
		customer4.OpenAccount(1570);
        bank1.AddCustomer(customer1);
		bank1.AddCustomer(customer2);
		bank2.AddCustomer(customer3);
		bank2.AddCustomer(customer4);
        foreach(var customer in bank1.GetCustomers()){
            Console.WriteLine($"{customer.GetName()} has balance: {customer.GetBalance():C}");
        }
		Console.WriteLine();
		foreach(var customer in bank2.GetCustomers()){
            Console.WriteLine($"{customer.GetName()} has balance: {customer.GetBalance():C}");
        }
    }
}
 */