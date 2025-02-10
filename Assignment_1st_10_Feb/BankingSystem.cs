/* using System;

interface ILoanable{
    void ApplyForLoan(double loanAmount);
    double CalculateLoanEligibility();
}

abstract class BankAccount{
    protected int accountNumber;
    protected string holderName;
    protected double balance;
    public BankAccount(int accountNumber,string holderName,double balance){
        this.accountNumber = accountNumber;
        this.holderName = holderName;
        this.balance = balance;
    }
    public void Deposit(double amount){
        this.balance += amount;
    }
    public void Withdraw(double amount){
        if(this.balance>=amount){
            this.balance -= amount;
        }
    }
    public abstract double CalculateInterest();
	public void ApplyForLoan(double loanAmount){
        Console.WriteLine($"Loan application submitted for amount: {loanAmount}");
    }
    public double CalculateLoanEligibility(){
        return balance*3;
    }
	public void DisplayAccountDetails(){
        Console.WriteLine($"Account Number: {accountNumber}, Holder Name: {holderName}, Balance: {balance}");
    }
}

class SavingsAccount:BankAccount{
    public SavingsAccount(int accountNumber,string holderName,double balance):base(accountNumber,holderName,balance){}
    public override double CalculateInterest(){
        return this.balance*0.04;
    }
}

class CurrentAccount:BankAccount{
    public CurrentAccount(int accountNumber,string holderName,double balance):base(accountNumber,holderName,balance){}
    public override double CalculateInterest(){
        return this.balance*0.02;
    }
}

class Program{
    public static void Main(string[] args){
        List<BankAccount> accounts = new List<BankAccount>{
            new SavingsAccount(101,"Ramesh",100000),
            new CurrentAccount(102,"Anjali",200000)
        };
        foreach(BankAccount account in accounts){
            account.DisplayAccountDetails();
        }
    }
}
 */