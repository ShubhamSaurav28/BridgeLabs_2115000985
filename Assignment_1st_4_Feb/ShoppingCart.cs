/* using System;

class Product{
    public static double Discount = 10.0;
    public readonly int ProductID;
    private string productName;
    private double price;
    private int quantity;
    public Product(int productID,string productName,double price,int quantity){
        this.ProductID = productID;
        this.productName = productName;
        this.price = price;
        this.quantity = quantity;
    }
    public static void UpdateDiscount(double newDiscount){
        Discount = newDiscount;
    }
    public void DisplayProductDetails(){
        if(this is Product){
            double totalPrice = price*quantity*(1-Discount/100);
            Console.WriteLine($"Product Name: {productName}");
            Console.WriteLine($"Product ID: {ProductID}");
            Console.WriteLine($"Price per Item: ₹{price}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Discount: {Discount}%");
            Console.WriteLine($"Total Price (after discount): ₹{totalPrice}");
        }
        else{
            Console.WriteLine("This object is not an instance of the Product class.");
        }
    }
}

class Program{
    public static void Main(string[] args){
        Product product1 = new Product(101,"Laptop",50000,2);
        Product product2 = new Product(102,"Smartphone",30000,3);
        Console.WriteLine("\nProduct 1 Details:");
        product1.DisplayProductDetails();
		Product.UpdateDiscount(15.0);
        Console.WriteLine("\nProduct 2 Details:");
        product2.DisplayProductDetails();
    }
}
 */