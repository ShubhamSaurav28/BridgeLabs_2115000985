/* using System;

public class Library{
    private List<Book> books;
    public Library(){
        books = new List<Book>();
    }
    public void AddBook(Book book){
        this.books.Add(book);
    }
    public List<Book> GetBooks(){
        return books;
    }
}

public class Book{
    private string title;
    private string author;
    public Book(string title,string author){
        this.title = title;
        this.author = author;
    }
    public string GetTitle(){
        return title;
    }
    public string GetAuthor(){
        return author;
    }
}

public class Program{
    public static void Main(string[] args){
        Library library1 = new Library();
		Library library2 = new Library();
        Book book1 = new Book("1920","Shubham");
        Book book2 = new Book("To Kill", "Saurav");
		Book book3 = new Book("1921","Shubham");
        Book book4 = new Book("Infinite", "Saurav");
        library1.AddBook(book1);
        library1.AddBook(book2);
		library2.AddBook(book3);
        library2.AddBook(book4);
        foreach(var book in library1.GetBooks()){
            Console.WriteLine($"{book.GetTitle()} by {book.GetAuthor()}");
        }
		Console.WriteLine();
		foreach(var book in library2.GetBooks()){
            Console.WriteLine($"{book.GetTitle()} by {book.GetAuthor()}");
        }
    }
}
 */