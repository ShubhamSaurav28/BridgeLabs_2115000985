//using System;
//using System.Text.RegularExpressions;

//public class PasswordValidator{
//    public bool IsValid(string password){
//        if(string.IsNullOrEmpty(password) || password.Length<8){
//            return false;
//		}
//        if(!Regex.IsMatch(password,@"[A-Z]")){
//            return false;
//		}
//        if(!Regex.IsMatch(password,@"\d")){
//            return false;
//		}
//        return true;
//    }
//}

//class Program{
//    public static void Main(){
//        PasswordValidator validator = new PasswordValidator();
//        string[] testPasswords = {"Hello123","password","HELLO123","hello123","Short1","ValidPass123"};
//        foreach(string password in testPasswords){
//            Console.WriteLine($"Password: {password} | Valid: {validator.IsValid(password)}");
//        }
//    }
//}
