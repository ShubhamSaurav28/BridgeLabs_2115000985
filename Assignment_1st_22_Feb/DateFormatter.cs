//using System;
//using System.Globalization;

//public class DateFormatter
//{
//    public string FormatDate(string inputDate)
//    {
//        if (DateTime.TryParseExact(inputDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
//        {
//            return parsedDate.ToString("dd-MM-yyyy");
//        }
//        throw new ArgumentException("Invalid date format. Expected format: yyyy-MM-dd");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        DateFormatter formatter = new DateFormatter();

//        Console.WriteLine("Formatted Dates:");
//        Console.WriteLine(formatter.FormatDate("2024-02-22")); // Expected: 22-02-2024
//        Console.WriteLine(formatter.FormatDate("2000-01-01")); // Expected: 01-01-2000

//        // Testing invalid input
//        try
//        {
//            Console.WriteLine(formatter.FormatDate("22-02-2024"));
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}
