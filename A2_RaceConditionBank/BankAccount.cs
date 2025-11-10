using System;
using System.Threading;

namespace A2_RaceConditionBank;
public class BankAccount
{
    object _lock = new object();

    private int balance;
   
    
    public BankAccount(int initial) 
    { 
        balance = initial; 
    }
    
    public void Deposit(int amount) 
    { 
        lock (_lock)
        {
            balance = balance + amount;
        }
       
    }
    
    public void Withdraw(int amount) 
    { 
        lock (_lock){
            balance = balance - amount;
        }
       
    }
    
    public int GetBalance() 
    {
        return balance;
    }
}
