using System;
using System.Threading;
 
namespace A1_ZweiThreadsZaehlenWinner;
 
class Program
{
 
    static int threadACount = 0;
    static int threadBCount = 0;

    static int number = 0;
 
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 1: Zwei Threads – Zählen & Winner");
        Thread threadA = new Thread(() => CountUpThreadA());
        Thread threadB = new Thread(() => CountDownThreadB());
 
        threadA.Start();
        threadB.Start();
 
        threadA.Join();
        threadB.Join();

        if(number == 51){
            Console.WriteLine($"thread up gewinnt - number: {number}");
        }else if(number == 49){
            Console.WriteLine($"thread down gewinnt - number: {number}");
        }
         
    }
   
    private static void CountUpThreadA()
    {
        for(int i = 1; i<= 100; i++)
        {
            threadACount = i;
            /*if(threadBCount == threadACount)
            {
                Console.WriteLine("B:" + threadBCount);
                Console.WriteLine("A:" + threadACount);
                break;
            }*/

            if(i == 51){
                number = 51;
            }
            Thread.Sleep(100);
        }
       
    }
   
    private static void CountDownThreadB()
    {
        for(int i = 100; i>= 1; i--)
        {
            threadBCount = i;
            /*if(threadACount == threadBCount)
            {
                Console.WriteLine("B:" + threadBCount);
                Console.WriteLine("A:" + threadACount);
                break;
            }*/
             if(i == 49){
                number = 49;
            }
            Thread.Sleep(100);
        }
    }
}
 
 