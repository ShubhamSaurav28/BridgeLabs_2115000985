/* using System;

class BankAccount{
    protected string accountNumber;
    protected double balance;
    public BankAccount(string accountNumber,double balance){
        this.accountNumber = accountNumber;
        this.balance = balance;
    }
}

class FixedDepositAccount:BankAccount{
    private double fixedAmount;
    public FixedDepositAccount(string accountNumber,double balance,double fixedAmount):base(accountNumber,balance){
        this.fixedAmount = fixedAmount;
    }
    public void DisplayAccountInfo(){
        Console.WriteLine($"Fixed Deposit Account Number: {this.accountNumber}, Balance: {this.balance}, Fixed Amount: {this.fixedAmount}");
    }
}

class CheckingAccount:BankAccount{
    private double withdrawalLimit;
    public CheckingAccount(string accountNumber,double balance,double withdrawalLimit):base(accountNumber,balance){
        this.withdrawalLimit = withdrawalLimit;
    }
    public void DisplayAccountInfo(){
        Console.WriteLine($"Checking Account Number: {this.accountNumber}, Balance: {this.balance}, Withdrawal Limit: {this.withdrawalLimit}");
    }
}

class SavingsAccount:BankAccount{
    private double interestRate;
    public SavingsAccount(string accountNumber,double balance,double interestRate):base(accountNumber,balance){
        this.interestRate = interestRate;
    }
    public void DisplayAccountInfo(){
        Console.WriteLine($"Savings Account Number: {this.accountNumber}, Balance: {this.balance}, Interest Rate: {this.interestRate}%");
    }
}

class Program{
    public static void Main(){
        SavingsAccount savings = new SavingsAccount("42612345",10000.50,3.5);
        CheckingAccount checking = new CheckingAccount("42667890",5000.75,2000);
        FixedDepositAccount fixedDeposit = new FixedDepositAccount("42611223",15000,20000);
        savings.DisplayAccountInfo();
        checking.DisplayAccountInfo();
        fixedDeposit.DisplayAccountInfo();
    }
}
 */