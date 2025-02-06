/* using System;
using System.Collections.Generic;

public class Customer{
    private string name;
    private List<Order> orders;
    public Customer(string name){
        this.name = name;
        orders = new List<Order>();
    }
    public void PlaceOrder(Order order){
        this.orders.Add(order);
        Console.WriteLine($"{name} placed an order with {order.GetProducts().Count} products.");
    }
    public string GetName(){
        return name;
    }
    public List<Order> GetOrders(){
        return orders;
    }
}

public class Order{
    private List<Product> products;
    public Order(){
        products = new List<Product>();
    }
    public void AddProduct(Product product){
        this.products.Add(product);
    }
    public List<Product> GetProducts(){
        return products;
    }
}

public class Product{
    private string name;
    private double price;
    public Product(string name,double price){
        this.name = name;
        this.price = price;
    }
    public string GetName(){
        return name;
    }
    public double GetPrice(){
        return price;
    }
}

public class Program{
    public static void Main(string[] args){
        Customer customer1 = new Customer("Aarav");
        Customer customer2 = new Customer("Ishita");
        Customer customer3 = new Customer("Rohan");
        Product product1 = new Product("Laptop",1000);
        Product product2 = new Product("Smartphone",500);
        Product product3 = new Product("Headphones",150);
        Order order1 = new Order();
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        Order order2 = new Order();
        order2.AddProduct(product3);
        customer1.PlaceOrder(order1);
        customer2.PlaceOrder(order2);
        customer3.PlaceOrder(order1);
        Console.WriteLine("\nOrder details:");
        foreach(var customer in new List<Customer> {customer1,customer2,customer3}){
            Console.WriteLine($"{customer.GetName()}'s Orders:");
            foreach(var order in customer.GetOrders()){
                foreach(var product in order.GetProducts()){
                    Console.WriteLine($"- {product.GetName()} priced at {product.GetPrice()}");
                }
            }
        }
    }
}
 */