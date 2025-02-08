/* using System;

class Book{
    protected string title;
    protected int publicationYear;
    public Book(string title,int publicationYear){
        this.title = title;
        this.publicationYear = publicationYear;
    }
    public virtual void DisplayInfo(){
        Console.WriteLine($"Book Title: {this.title}, Publication Year: {this.publicationYear}");
    }
}

class Author:Book{
    private string name;
    private string bio;
    public Author(string title,int publicationYear,string name,string bio):base(title,publicationYear){
        this.name = name;
        this.bio = bio;
    }
    public override void DisplayInfo(){
        Console.WriteLine($"Book Title: {this.title}, Publication Year: {this.publicationYear}");
        Console.WriteLine($"Author Name: {this.name}, Bio: {this.bio}");
    }
}

class Program{
    public static void Main(){
        Author bookWithAuthor = new Author("The Great Library",2025,"Shubham","I am a good boy.");
        bookWithAuthor.DisplayInfo();
    }
}
 */