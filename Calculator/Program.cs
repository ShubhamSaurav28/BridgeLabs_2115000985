using System;

class Calculator{
    public static void Main(){
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("1 for Add, 2 for Subtract");
        int choice = int.Parse(Console.ReadLine());
        switch (choice){
            case 1:
                Console.WriteLine(Add(a, b));
                break;
            case 2:
                Console.WriteLine(Sub(a, b));
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Sub(int a, int b)
    {
        return a - b;
    }
}
