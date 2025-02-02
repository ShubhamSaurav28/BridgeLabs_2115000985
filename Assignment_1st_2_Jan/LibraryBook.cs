//using System;

//public class LibraryBook{
//    public string Title;
//    public string Author;
//    public double Price;
//    public bool IsAvailable;
//    public LibraryBook(string title,string author,double price){
//        Title = title;
//        Author = author;
//        Price = price;
//        IsAvailable = true;
//    }
//    public void BorrowBook(){
//        if (IsAvailable){
//            IsAvailable = false;
//            Console.WriteLine($"{Title} has been borrowed.");
//        }
//        else{
//            Console.WriteLine($"{Title} is currently unavailable.");
//        }
//    }
//    public void DisplayBookDetails(){
//        Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}, Availability: {IsAvailable}");
//    }
//}

//public class Program{
//    public static void Main(string[] args){
//        LibraryBook book = new LibraryBook("C# Programming","Shubham",29.99);
//        book.DisplayBookDetails();
//        book.BorrowBook();
//        book.DisplayBookDetails();
//        book.BorrowBook();
//    }
//}
