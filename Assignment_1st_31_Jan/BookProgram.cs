//using System;

//class Book{
//    private string title;
//    private string author;
//    private double price;
//    public void SetTitle(string title){
//        this.title = title;
//    }
//    public string GetTitle(){
//        return title;
//    }
//    public void SetAuthor(string author){
//        this.author = author;
//    }
//    public string GetAuthor(){
//        return author;
//    }
//    public void SetPrice(double price){
//        if(price>0){
//            this.price = price;
//        }
//        else{
//            Console.WriteLine("Price must be positive.");
//        }
//    }
//    public double GetPrice(){
//        return price;
//    }
//    public void DisplayDetails(){
//        Console.WriteLine($"Title: {GetTitle()}");
//        Console.WriteLine($"Author: {GetAuthor()}");
//        Console.WriteLine($"Price(Rs): {GetPrice()}");
//    }
//}

//class Program{
//    public static void Main(){
//        Book book = new Book();
//        book.SetTitle("C# Programmer");
//        book.SetAuthor("Shubham");
//        book.SetPrice(499.99);
//        book.DisplayDetails();
//    }
//}
