//using System;

//public class BankAccount{
//    private double balance;
//    public BankAccount(double initialBalance = 0){
//        balance = initialBalance;
//    }
//    public void Deposit(double amount){
//        if(amount<=0){
//            throw new ArgumentException("Deposit amount must be positive.");
//        }
//        balance += amount;
//    }
//    public void Withdraw(double amount){
//        if(amount<=0){
//            throw new ArgumentException("Withdrawal amount must be positive.");
//        }
//        if(amount>balance){
//            throw new InvalidOperationException("Insufficient funds.");
//        }
//        balance -= amount;
//    }
//    public double GetBalance(){
//        return balance;
//    }
//}

//class Program{
//    public static void Main(){
//        BankAccount account = new BankAccount(1000);
//        Console.WriteLine("Initial Balance: "+account.GetBalance());
//        account.Deposit(500);
//        Console.WriteLine("Balance after deposit: "+account.GetBalance());
//        try{
//            account.Withdraw(200);
//            Console.WriteLine("Balance after withdrawal: "+account.GetBalance());
//        }
//        catch(Exception ex){
//            Console.WriteLine("Error: "+ex.Message);
//        }
//        try{
//            account.Withdraw(2000);
//        }
//        catch (Exception ex){
//            Console.WriteLine("Error: "+ex.Message);
//        }
//    }
//}
