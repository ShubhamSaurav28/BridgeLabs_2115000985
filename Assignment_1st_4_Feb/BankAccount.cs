/* using System;
using System.Collections.Generic;

class BankAccount{
    public static string bankName = "SBI";
    private static int totalAccounts = 0;
    private readonly int accountNumber;
    private string accountHolderName;
    private double balance;
    public static void GetTotalAccounts(){
        Console.WriteLine($"Total Accounts: {totalAccounts}");
    }
    public BankAccount(string accountHolderName,int accountNumber){
        this.accountHolderName = accountHolderName;
        this.accountNumber = accountNumber;
        balance = 0;
        totalAccounts++;
    }
    public int GetAccountNumber(){
        return accountNumber;
    }
    public void Deposit(double amount){
        if(amount>0){
            balance += amount;
            Console.WriteLine($"₹{amount} deposited successfully.");
        }
        else{
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    public void Withdraw(double amount){
        if(amount>0 && amount<=balance){
            balance -= amount;
            Console.WriteLine($"₹{amount} withdrawn successfully.");
        }
        else if(amount>balance){
            Console.WriteLine("Insufficient balance.");
        }
        else{
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }
    public void GetBalance(){
        Console.WriteLine($"Current Balance: ₹{balance}");
    }
    public void DisplayAccountDetails(){
        Console.WriteLine($"Bank Name: {bankName}");
        Console.WriteLine($"Account Holder: {accountHolderName}");
        Console.WriteLine($"Account Number: {accountNumber}");
    }
}

class Program{
    public static void Main(string[] args){
        List<BankAccount> accounts = new List<BankAccount>();
        accounts.Add(new BankAccount("Alice Johnson",101));
        accounts.Add(new BankAccount("Bob Smith",102));
        bool exit = false;
        BankAccount.GetTotalAccounts();
        while(!exit){
            Console.WriteLine("\n--- Select an Account ---");
            for(int i=0;i<accounts.Count;i++){
                Console.WriteLine($"{i + 1}. Account Number: {accounts[i].GetAccountNumber()}");
            }
            Console.WriteLine($"{accounts.Count + 1}. Exit");
            Console.Write("Select an account (1-"+(accounts.Count+1)+"): ");
            if(int.TryParse(Console.ReadLine(),out int accountChoice) && accountChoice>=1 && accountChoice<=accounts.Count){
                BankAccount selectedAccount = accounts[accountChoice-1];
                bool loop = true;
                while(loop){
                    Console.WriteLine($"\n--- {BankAccount.bankName} Bank Account Menu ---");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Display Account Details");
                    Console.WriteLine("5. Back to Account Selection");
                    Console.Write("Select an option (1-5): ");
                    string choice = Console.ReadLine();
                    switch(choice){
                        case "1":
                            Console.Write("Enter deposit amount: ₹");
                            if(double.TryParse(Console.ReadLine(),out double depositAmount)){
                                selectedAccount.Deposit(depositAmount);
                            }
                            else{
                                Console.WriteLine("Invalid amount entered.");
                            }
                            break;
                        case "2":
                            Console.Write("Enter withdrawal amount: ₹");
                            if(double.TryParse(Console.ReadLine(),out double withdrawalAmount)){
                                selectedAccount.Withdraw(withdrawalAmount);
                            }
                            else{
                                Console.WriteLine("Invalid amount entered.");
                            }
                            break;
                        case "3":
                            selectedAccount.GetBalance();
                            break;
                        case "4":
                            selectedAccount.DisplayAccountDetails();
                            break;
                        case "5":
                            loop = false;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please select a valid choice.");
                            break;
                    }
                }
            }
            else if(accountChoice==accounts.Count+1){
                Console.WriteLine("Thank you for using our service.");
                exit = true;
            }
            else{
                Console.WriteLine("Invalid selection. Please select a valid account.");
            }
        }
    }
}
 */