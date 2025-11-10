using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
   int countUp = 0;
   int countDown = 0;
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 1: Zwei Threads – Zählen & Winner");
        
        Thread thread1 = new Thread(() => CountUpThreadA());
        Thread thread2 = new Thread(() => CountDownThreadB());
        
        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
    }
    
    private static void CountUpThreadA()
    {
        for(int i = 1; i <= 100; i++)
        {
            Thread.Sleep(100);
            countUp = countUp + 1;
        }
    }
    
    private static void CountDownThreadB()
    {
       for(int i = 1; i <= 100; i++)
        {
            Thread.Sleep(100);
            countDown = countDown - 1;
        }
    }
}
