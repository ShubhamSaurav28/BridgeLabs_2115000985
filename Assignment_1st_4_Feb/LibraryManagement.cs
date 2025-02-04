/* using System;

class Book{
    public static string LibraryName = "Shubham Library";  
    public static void DisplayLibraryName(){
        Console.WriteLine($"Library Name: {LibraryName}");
    }
    public readonly string ISBN;
    private string title;
    private string author;
    public Book(string title,string author,string isbn){
        this.title = title;
        this.author = author;
        this.ISBN = isbn;
    }
    public void DisplayBookDetails(){
        if(this is Book){
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
        else{
            Console.WriteLine("This object is not an instance of the Book class.");
        }
    }
}

class Program{
    public static void Main(string[] args){
        Book.DisplayLibraryName();
        Book book1 = new Book("The Great Magician","Harry Potter","978-0743273565");
        Book book2 = new Book("Infinity","Shubham","978-0451524935");
        Console.WriteLine("\nBook 1 Details:");
        book1.DisplayBookDetails();
        Console.WriteLine("\nBook 2 Details:");
        book2.DisplayBookDetails();
    }
}
 */