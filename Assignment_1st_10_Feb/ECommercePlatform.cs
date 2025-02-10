/* using System;

interface ITaxable{
    double CalculateTax();
    string GetTaxDetails();
}

abstract class Product{
    protected int productId;
    protected string name;
    protected double price;
    public Product(int productId,string name,double price){
        this.productId = productId;
        this.name = name;
        this.price = price;
    }
    public abstract double CalculateDiscount();
    public virtual void DisplayProductDetails(){
        Console.WriteLine($"Product ID: {productId}, Name: {name}, Price: {price}");
    }
	public double GetPrice(){
        return this.price;
    }
}

class Electronics:Product,ITaxable{
    private double warrantyCost;
    public Electronics(int productId,string name,double price,double warrantyCost):base(productId,name,price){
        this.warrantyCost = warrantyCost;
    }
    public override double CalculateDiscount(){
        return price*0.1;
    }
    public double CalculateTax(){
        return price*0.18;
    }
    public string GetTaxDetails(){
        return "Tax rate for Electronics is 18%.";
    }
}

class Clothing:Product,ITaxable{
    private string fabricType;
    public Clothing(int productId,string name,double price,string fabricType):base(productId,name,price){
        this.fabricType = fabricType;
    }
    public override double CalculateDiscount(){
        return price*0.2;
    }
    public double CalculateTax(){
        return price*0.05;
    }
    public string GetTaxDetails(){
        return "Tax rate for Clothing is 5%.";
    }
}

class Groceries:Product,ITaxable{
    private double weight;
    public Groceries(int productId,string name,double price,double weight):base(productId,name,price){
        this.weight = weight;
    }
    public override double CalculateDiscount(){
        return price*0.05;
    }
    public double CalculateTax(){
        return price*0.02;
    }
    public string GetTaxDetails(){
        return "Tax rate for Groceries is 2%.";
    }
}


class Program{
    public static void Main(string[] args){
        Electronics product1 = new Electronics(1,"Laptop",50000,2000);
        Clothing product2 = new Clothing(2,"T-shirt",1000,"Cotton");
        Groceries product3 = new Groceries(3,"Rice",2000,5.0);
        ProcessProduct(product1);
        ProcessProduct(product2);
        ProcessProduct(product3);
    }
	public static void ProcessProduct(Product product){
        product.DisplayProductDetails();
        double discount = product.CalculateDiscount();
        double tax = ((ITaxable)product).CalculateTax();
        double finalPrice = product.GetPrice()+tax-discount;
        Console.WriteLine($"Final Price after Discount and Tax: {finalPrice}");
        Console.WriteLine();
    }
}
 */