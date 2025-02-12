/* using System;

class Node
{
    public int BookID;
    public string Title;
    public string Author;
    public string Genre;
    public bool IsAvailable;
    public Node Prev, Next;

    public Node(int bookID, string title, string author, string genre, bool isAvailable)
    {
        BookID = bookID;
        Title = title;
        Author = author;
        Genre = genre;
        IsAvailable = isAvailable;
        Prev = null;
        Next = null;
    }
}

class LibraryManager
{
    private Node head, tail;
    private int count;
    public void AddBookAtBeginning(int bookID, string title, string author, string genre, bool isAvailable)
    {
        Node newBook = new Node(bookID, title, author, genre, isAvailable);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        count++;
        Console.WriteLine("Book added at the beginning.");
    }
    public void AddBookAtEnd(int bookID, string title, string author, string genre, bool isAvailable)
    {
        Node newBook = new Node(bookID, title, author, genre, isAvailable);
        if (head == null)
        {
            head = tail = newBook;
        }
        else
        {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        count++;
        Console.WriteLine("Book added at the end.");
    }
    public void AddBookAtPosition(int position, int bookID, string title, string author, string genre, bool isAvailable)
    {
        if (position <= 0 || position > count + 1)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        if (position == 1)
        {
            AddBookAtBeginning(bookID, title, author, genre, isAvailable);
            return;
        }
        if (position == count + 1)
        {
            AddBookAtEnd(bookID, title, author, genre, isAvailable);
            return;
        }

        Node newBook = new Node(bookID, title, author, genre, isAvailable);
        Node temp = head;

        for (int i = 1; i < position - 1; i++)
        {
            temp = temp.Next;
        }

        newBook.Next = temp.Next;
        newBook.Prev = temp;
        temp.Next.Prev = newBook;
        temp.Next = newBook;

        count++;
        Console.WriteLine($"Book added at position {position}.");
    }
    public void RemoveBook(int bookID)
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Node temp = head;

        while (temp != null && temp.BookID != bookID)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Book not found.");
            return;
        }

        if (temp == head)
        {
            head = head.Next;
            if (head != null) head.Prev = null;
        }
        else if (temp == tail)
        {
            tail = tail.Prev;
            tail.Next = null;
        }
        else
        {
            temp.Prev.Next = temp.Next;
            temp.Next.Prev = temp.Prev;
        }

        count--;
        Console.WriteLine($"Book {bookID} removed.");
    }
    public void SearchByTitle(string title)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Book Found: ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }
    public void SearchByAuthor(string author)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Book Found: ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
            }
            temp = temp.Next;
        }
    }
    public void UpdateAvailability(int bookID, bool isAvailable)
    {
        Node temp = head;
        while (temp != null)
        {
            if (temp.BookID == bookID)
            {
                temp.IsAvailable = isAvailable;
                Console.WriteLine($"Availability updated for Book {bookID}.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found.");
    }
    public void DisplayForward()
    {
        if (head == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("Books in Forward Order:");
        Node temp = head;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
            temp = temp.Next;
        }
    }
    public void DisplayReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("Library is empty.");
            return;
        }

        Console.WriteLine("Books in Reverse Order:");
        Node temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"ID: {temp.BookID}, Title: {temp.Title}, Author: {temp.Author}, Genre: {temp.Genre}, Available: {temp.IsAvailable}");
            temp = temp.Prev;
        }
    }
    public void CountBooks()
    {
        Console.WriteLine($"Total number of books: {count}");
    }
}

class Program{
    public static void Main()
    {
        LibraryManager library = new LibraryManager();

        library.AddBookAtBeginning(101, "The Alchemist", "Paulo Coelho", "Fiction", true);
        library.AddBookAtEnd(102, "1984", "George Orwell", "Dystopian", false);
        library.AddBookAtPosition(2, 103, "Sapiens", "Yuval Noah Harari", "History", true);

        library.DisplayForward();

        library.UpdateAvailability(102, true);
        library.SearchByTitle("1984");
        library.SearchByAuthor("Paulo Coelho");

        library.RemoveBook(101);
        library.DisplayReverse();

        library.CountBooks();
    }
}
 */