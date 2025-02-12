/* using System;

class Movie
{
    public string Title;
    public string Director;
    public int Year;
    public double Rating;
    public Movie Next;
    public Movie Prev;

    public Movie(string title, string director, int year, double rating)
    {
        Title = title;
        Director = director;
        Year = year;
        Rating = rating;
        Next = null;
        Prev = null;
    }
}

class MovieList
{
    private Movie head;
    private Movie tail;
    public void AddMovieAtBeginning(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = tail = newMovie;
        }
        else
        {
            newMovie.Next = head;
            head.Prev = newMovie;
            head = newMovie;
        }
        Console.WriteLine("Movie added at the beginning.");
    }
    public void AddMovieAtEnd(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (tail == null)
        {
            head = tail = newMovie;
        }
        else
        {
            tail.Next = newMovie;
            newMovie.Prev = tail;
            tail = newMovie;
        }
        Console.WriteLine("Movie added at the end.");
    }
    public void AddMovieAtPosition(int position, string title, string director, int year, double rating)
    {
        if (position <= 0)
        {
            Console.WriteLine("Invalid position.");
            return;
        }

        Movie newMovie = new Movie(title, director, year, rating);

        if (position == 1)
        {
            AddMovieAtBeginning(title, director, year, rating);
            return;
        }

        Movie temp = head;
        for (int i = 1; temp != null && i < position - 1; i++)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Position out of bounds.");
            return;
        }

        newMovie.Next = temp.Next;
        newMovie.Prev = temp;
        if (temp.Next != null)
        {
            temp.Next.Prev = newMovie;
        }
        temp.Next = newMovie;

        if (newMovie.Next == null)
        {
            tail = newMovie;
        }

        Console.WriteLine("Movie added at position " + position);
    }
    public void RemoveMovie(string title)
    {
        if (head == null)
        {
            Console.WriteLine("Movie list is empty.");
            return;
        }

        Movie temp = head;

        while (temp != null && temp.Title != title)
        {
            temp = temp.Next;
        }

        if (temp == null)
        {
            Console.WriteLine("Movie not found.");
            return;
        }

        if (temp.Prev != null)
        {
            temp.Prev.Next = temp.Next;
        }
        else
        {
            head = temp.Next;
        }

        if (temp.Next != null)
        {
            temp.Next.Prev = temp.Prev;
        }
        else
        {
            tail = temp.Prev;
        }

        Console.WriteLine("Movie '" + title + "' removed.");
    }
    public void SearchMovieByDirector(string director)
    {
        Movie temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Director.Equals(director, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Movie Found: {temp.Title} directed by {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found by this director.");
    }
    public void SearchMovieByRating(double rating)
    {
        Movie temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Rating == rating)
            {
                Console.WriteLine($"Movie Found: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("No movies found with this rating.");
    }
    public void UpdateMovieRating(string title, double newRating)
    {
        Movie temp = head;

        while (temp != null)
        {
            if (temp.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                temp.Rating = newRating;
                Console.WriteLine("Rating updated for '" + title + "'.");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Movie not found.");
    }
    public void DisplayMoviesForward()
    {
        if (head == null)
        {
            Console.WriteLine("No movies in the list.");
            return;
        }

        Console.WriteLine("Movies (Forward Order):");
        Movie temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Next;
        }
    }
    public void DisplayMoviesReverse()
    {
        if (tail == null)
        {
            Console.WriteLine("No movies in the list.");
            return;
        }

        Console.WriteLine("Movies (Reverse Order):");
        Movie temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.Title}, Director: {temp.Director}, Year: {temp.Year}, Rating: {temp.Rating}");
            temp = temp.Prev;
        }
    }
}

class Program
{
    static void Main()
    {
        MovieList movieList = new MovieList();

        movieList.AddMovieAtBeginning("Inception", "Christopher Nolan", 2010, 8.8);
        movieList.AddMovieAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);
        movieList.AddMovieAtPosition(2, "The Dark Knight", "Christopher Nolan", 2008, 9.0);
        
        movieList.DisplayMoviesForward();

        Console.WriteLine("\nSearching for movies by Christopher Nolan:");
        movieList.SearchMovieByDirector("Christopher Nolan");

        Console.WriteLine("\nUpdating rating for 'Interstellar':");
        movieList.UpdateMovieRating("Interstellar", 9.1);
        movieList.DisplayMoviesForward();

        Console.WriteLine("\nRemoving 'The Dark Knight':");
        movieList.RemoveMovie("The Dark Knight");
        movieList.DisplayMoviesForward();

        Console.WriteLine("\nDisplaying movies in reverse order:");
        movieList.DisplayMoviesReverse();
    }
}
 */