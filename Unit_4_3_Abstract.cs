/* Create a class “Account” containing accountNo, and balance 
as an instance variable .Derive the Account class into two 
classes named “Savings” and “Current”. The“Savings” class 
should contain instance variable named interest Rate, and 
the “Current” 
class should contain an instance variable called overdraft 
Limit. Define appropriate methods for all the classes to 
enable functionalities to check balance, deposit, and 
withdraw amounts in Savings and Current accounts. 
(Use the concept of Abstract class) */ 

using System;


abstract class Account
{
    protected int accountNo;
    protected double balance;

  
    public Account(int accNo, double bal)
    {
        accountNo = accNo;
        balance = bal;
    }

 
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }

    public void CheckBalance()
    {
        Console.WriteLine("Account No: " + accountNo);
        Console.WriteLine("Balance: " + balance);
    }

   
    public abstract void Withdraw(double amount);
}


class Savings : Account
{
    double interestRate;

    public Savings(int accNo, double bal, double rate) : base(accNo, bal)
    {
        interestRate = rate;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Savings: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance in Savings");
        }
    }
}


class Current : Account
{
    double overdraftLimit;

    public Current(int accNo, double bal, double limit) : base(accNo, bal)
    {
        overdraftLimit = limit;
    }

    public override void Withdraw(double amount)
    {
        if (amount <= (balance + overdraftLimit))
        {
            balance -= amount;
            Console.WriteLine("Withdrawn from Current: " + amount);
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded");
        }
    }
}


class Program
{
    static void Main()
    {
        
        Savings s = new Savings(101, 5000, 5);
        s.CheckBalance();
        s.Deposit(1000);
        s.Withdraw(2000);
        s.CheckBalance();

        Console.WriteLine();

        
        Current c = new Current(102, 3000, 2000);
        c.CheckBalance();
        c.Deposit(500);
        c.Withdraw(4500);
        c.CheckBalance();
    }
}