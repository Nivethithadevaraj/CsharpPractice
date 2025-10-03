using System;
abstract class Account{
    private static double balance = 0;
    public static void deposit(double amount){
        balance += amount;
    }
    public static double getBalance(){
        return balance;
    }}
public class Program
{
    static void Main()
    {
        Account.deposit(1000);
        Console.WriteLine(Account.getBalance());
    }
}