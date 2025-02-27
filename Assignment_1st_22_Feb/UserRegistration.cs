/* using System;
using System.Text.RegularExpressions;

public class UserRegistration
{
    public void RegisterUser(string username, string email, string password)
    {
        if (string.IsNullOrWhiteSpace(username) || username.Length < 3)
        {
            throw new ArgumentException("Username must be at least 3 characters long.");
        }

        if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        {
            throw new ArgumentException("Invalid email format.");
        }

        if (password.Length < 8 || !Regex.IsMatch(password, @"[A-Z]") || !Regex.IsMatch(password, @"\d"))
        {
            throw new ArgumentException("Password must be at least 8 characters long, contain one uppercase letter, and one digit.");
        }

        Console.WriteLine($"User '{username}' registered successfully!");
    }
} */

//class Program
//{
//    static void Main()
//    {
//        UserRegistration userReg = new UserRegistration();

//        try
//        {
//            userReg.RegisterUser("JohnDoe", "johndoe@example.com", "Password123");
//            userReg.RegisterUser("JD", "invalid-email", "pass"); // This should throw an exception
//        }
//        catch (ArgumentException ex)
//        {
//            Console.WriteLine($"Error: {ex.Message}");
//        }
//    }
//}
