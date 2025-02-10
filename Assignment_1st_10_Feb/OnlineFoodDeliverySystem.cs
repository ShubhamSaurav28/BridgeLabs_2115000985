/* using System;

interface IDiscountable{
    void ApplyDiscount(double discountPercentage);
    string GetDiscountDetails();
}

abstract class FoodItem{
    protected string itemName;
    protected double price;
    protected int quantity;
    public FoodItem(string itemName,double price,int quantity){
        this.itemName = itemName;
        this.price = price;
        this.quantity = quantity;
    }
    public abstract double CalculateTotalPrice();
    public void GetItemDetails(){
        Console.WriteLine($"Item: {this.itemName}, Price per unit: {this.price}, Quantity: {this.quantity}");
    }
}

class VegItem:FoodItem{
    public VegItem(string itemName,double price,int quantity):base(itemName,price,quantity){}
    public override double CalculateTotalPrice(){
        return this.price*this.quantity;
    }
}

class NonVegItem:FoodItem{
    public NonVegItem(string itemName,double price,int quantity):base(itemName,price,quantity){}
    public override double CalculateTotalPrice(){
        return this.price*this.quantity*1.1;
    }
}

class Program{
    public static void Main(string[] args){
        List<FoodItem> items = new List<FoodItem>{
            new VegItem("Paneer Tikka",200,2),
            new NonVegItem("Chicken Biryani",300,1)
        };
        foreach(FoodItem item in items){
            item.GetItemDetails();
            Console.WriteLine($"Total Price: {item.CalculateTotalPrice()}");
        }
    }
}
 */