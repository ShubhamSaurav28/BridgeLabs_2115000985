/* using System;

class Product{
    private string productName;
    private double pricePerUnit;
    private double quantity;
    public string GetProductName(){
        return this.productName;
    }
    public void SetProductName(string productName){
        this.productName = productName;
    }
    public double GetPricePerUnit(){
        return this.pricePerUnit;
    }
    public void SetPricePerUnit(double pricePerUnit){
        this.pricePerUnit = pricePerUnit;
    }
    public double GetQuantity(){
        return this.quantity;
    }
    public void SetQuantity(double quantity){
        this.quantity = quantity;
    }
    public Product(string productName,double pricePerUnit,double quantity){
        this.SetProductName(productName);
        this.SetPricePerUnit(pricePerUnit);
        this.SetQuantity(quantity);
    }
    public double GetTotalPrice(){
        return this.pricePerUnit*this.quantity;
    }
}

class Customer{
    private string name;
    private List<Product> products;
    public string GetName(){
        return this.name;
    }
    public void SetName(string name){
        this.name = name;
    }
    public List<Product> GetProducts(){
        return this.products;
    }
    public void SetProducts(List<Product> products){
        this.products = products;
    }
    public Customer(string name){
        this.SetName(name);
        this.products = new List<Product>();
    }
    public void AddProduct(Product product){
        this.products.Add(product);
    }
}

class BillGenerator{
    public static void GenerateBill(Customer customer){
        Console.WriteLine($"Customer: {customer.GetName()}");
        double totalAmount = 0;
        foreach(Product product in customer.GetProducts()){
            double productTotal = product.GetTotalPrice();
            totalAmount += productTotal;
            Console.WriteLine($"{product.GetProductName()}: {product.GetQuantity()} units at ${product.GetPricePerUnit()} per unit - Total: ${productTotal:F2}");
        }
        Console.WriteLine($"Total Bill Amount: ${totalAmount:F2}");
    }
}

class Program{
    public static void Main(string[] args){
        Customer customer = new Customer("Alice");
        customer.AddProduct(new Product("Apples",3.0,2.0));
        customer.AddProduct(new Product("Milk",2.0,1.0));
        Console.WriteLine("Generating Bill...");
        BillGenerator.GenerateBill(customer);
    }
}
 */