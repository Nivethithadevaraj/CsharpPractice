using System;
class BankAccount{
    private double balance;
    public BankAccount(double initialBalance){
        balance = initialBalance;
    }
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited {amount}, New Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }
    public void Withdraw(double amount){
        if (amount <= balance){
            balance -= amount;
            Console.WriteLine($"Withdrawn {amount}, Remaining Balance: {balance}");
        }
        else{
            Console.WriteLine("Insufficient balance.");
        }
    }
    public double GetBalance(){
        return balance;
    }
}
public class Program{
    static void Main(){
        BankAccount account = new BankAccount(1000);
        account.Deposit(500);
        account.Withdraw(200);     
        Console.WriteLine($"Final Balance: {account.GetBalance()}");
    }}