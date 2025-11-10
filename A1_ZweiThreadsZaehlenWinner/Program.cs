using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
   static int countUp = 0;
   static int countDown = 0;
    
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
            System.Console.WriteLine(countUp);
        }
    }
    
    private static void CountDownThreadB()
    {
       for(int i = 100; i <= 1; i--)
        {
            Thread.Sleep(100);
            countDown = countDown - 1;
            System.Console.WriteLine(countDown);
        }
    }
}
