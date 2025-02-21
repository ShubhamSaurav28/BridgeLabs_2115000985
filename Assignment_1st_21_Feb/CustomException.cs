/* using System;

class InvalidAgeException:Exception{
    public InvalidAgeException(string message):base(message){}
}

class Program{
    public static void ValidateAge(int age){
        if(age<18){
            throw new InvalidAgeException("Age must be 18 or above");
        }
        Console.WriteLine("Access granted!");
    }
    public static void Main(){
        try{
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            ValidateAge(age);
        }
        catch(InvalidAgeException ex){
            Console.WriteLine(ex.Message);
        }
    }
} */