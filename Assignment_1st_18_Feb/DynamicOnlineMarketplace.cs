/* using System;

abstract class ProductCategory{}

class BookCategory:ProductCategory{}

class ClothingCategory:ProductCategory{}

class Product<T> where T:ProductCategory{
    public string Name{get;set;}
    public double Price{get;set;}
    public Product(string name,double price){
        Name = name;
        Price = price;
    }
}

class Marketplace{
    public static void ApplyDiscount<T>(T product,double percentage) where T:Product<ProductCategory>{
        product.Price -= product.Price*(percentage/100);
        Console.WriteLine($"New price of {product.Name}: {product.Price}");
    }
}

class Program{
    public static void Main(){
        var book = new Product<BookCategory>("C# Programming",500);
        Marketplace.ApplyDiscount(book,10);
    }
} */