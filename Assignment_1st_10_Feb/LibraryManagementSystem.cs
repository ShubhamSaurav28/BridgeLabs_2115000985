/* using System;

interface IReservable{
    void ReserveItem(string borrowerName);
    bool CheckAvailability();
}

abstract class LibraryItem{
    protected int itemId;
    protected string title;
    protected string author;
    public LibraryItem(int itemId, string title, string author){
        this.itemId = itemId;
        this.title = title;        
		this.author = author;
	}
    public abstract int GetLoanDuration();
    public void GetItemDetails(){
        Console.WriteLine($"ID: {this.itemId}, Title: {this.title}, Author: {this.author}");
    }
}

class Book:LibraryItem{
    public Book(int itemId,string title,string author):base(itemId,title,author){}
    public override int GetLoanDuration(){
        return 14;
    }
}

class DVD:LibraryItem{
    public DVD(int itemId,string title,string author):base(itemId,title,author){}
    public override int GetLoanDuration(){
        return 7;
    }
}

class Program{
    public static void Main(string[] args){
        List<LibraryItem> items = new List<LibraryItem>{
            new Book(1,"Mahabharat","Ved Vyas"),
            new DVD(2,"Chhichhore","Nitesh Tiwari")
        };
        foreach(LibraryItem item in items){
            item.GetItemDetails();
            Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");
        }
    }
}
 */