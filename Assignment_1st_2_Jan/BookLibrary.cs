//using System;

//public class Book{
//    public string ISBN;
//    protected string Title;
//    private string Author;
//    public Book(string isbn, string title, string author){
//        ISBN = isbn;
//        Title = title;
//        Author = author;
//    }
//    public string GetAuthor(){
//        return Author;
//    }
//    public void SetAuthor(string author){
//        Author = author;
//    }
//}

//public class EBook:Book{
//    public EBook(string isbn,string title,string author):base(isbn,title,author){
//    }
//    public void DisplayBookDetails(){
//        Console.WriteLine($"ISBN: {ISBN}, Title: {Title}, Author: {GetAuthor()}");
//    }
//}

//public class Program{
//    public static void Main(string[] args){
//        EBook ebook = new EBook("978-3-16-148410-0", "C# Programming", "Shubham");
//        ebook.DisplayBookDetails();
//        ebook.SetAuthor("Ram");
//        Console.WriteLine($"Updated Author: {ebook.GetAuthor()}");
//    }
//}
