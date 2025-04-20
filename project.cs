using System;
using System.Collections.Generic;

class BankAccount
{
    public string Owner { get; set; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount} successfully.");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds.");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount} successfully.");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Current balance: {Balance}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Simple Bank App!");
        Console.Write("Enter your name to create an account: ");
        string name = Console.ReadLine();

        BankAccount account = new BankAccount(name);
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Deposit Money");
            Console.WriteLine("3. Withdraw Money");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    account.ShowBalance();
                    break;
                case "2":
                    Console.Write("Enter amount to deposit: ");
                    decimal deposit = decimal.Parse(Console.ReadLine());
                    account.Deposit(deposit);
                    break;
                case "3":
                    Console.Write("Enter amount to withdraw: ");
                    decimal withdraw = decimal.Parse(Console.ReadLine());
                    account.Withdraw(withdraw);
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Thank you for using Simple Bank App!");
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
