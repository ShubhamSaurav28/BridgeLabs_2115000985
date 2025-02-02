//using System;

//public class BankAccount{
//    public string AccountNumber;
//    protected string AccountHolder;
//    private double Balance;
//    public BankAccount(string accountNumber,string accountHolder,double balance){
//        AccountNumber = accountNumber;
//        AccountHolder = accountHolder;
//        Balance = balance;
//    }
//    public void Deposit(double amount){
//        Balance += amount;
//    }
//    public double GetBalance(){
//        return Balance;
//    }
//}

//public class SavingsAccount:BankAccount{
//    public SavingsAccount(string accountNumber,string accountHolder,double balance):base(accountNumber,accountHolder,balance){
//    }
//    public void DisplayAccountDetails(){
//        Console.WriteLine($"Account Number: {AccountNumber}, Account Holder: {AccountHolder}, Balance: {GetBalance()}");
//    }
//}

//public class Program{
//    public static void Main(string[] args){
//        SavingsAccount savingsAccount = new SavingsAccount("123456","Shubham",1000.0);
//        savingsAccount.DisplayAccountDetails();
//        savingsAccount.Deposit(500.0);
//        Console.WriteLine($"Updated Balance: {savingsAccount.GetBalance()}");
//    }
//}
