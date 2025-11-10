using System;
using System.Threading;
 
namespace A2_RaceConditionBank;
 
class Program
{
    public static void Main(string[] args)
    {
        List<Thread> threads = new List<Thread>();
        Console.WriteLine("Übung 2: Race Condition – Bankkonto");
        Console.WriteLine("==========================================\n");
 
        
        BankAccount account = new BankAccount(1000);
        Console.WriteLine($"Startkontostand: {account.GetBalance()} EUR\n");
        PerformBankOperations(account);
    }
 
    private static void PerformBankOperations(BankAccount account)
    {
        Thread thread1 = new Thread(() =>
        {
            for (int i = 0; i < 10; i++)
            {
                account.Deposit(100);
                Thread.Sleep(100);
                account.Withdraw(150);
            }
        });
 
 
        thread1.Start();
 
        thread1.Join();
 
        Console.WriteLine($"Endkontostand: {account.GetBalance()} EUR");
    }
}
 