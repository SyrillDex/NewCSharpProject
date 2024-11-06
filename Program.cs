using System;
using System.Threading;


namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "main";

            Thread thread1 = new Thread(() => countUp("timer 1"));
            Thread thread2 = new Thread(() => countDown("timer 2"));

            thread1.Start();
            thread2.Start();
        }
        public static void countUp(String name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(name + " " + i);
                Thread.Sleep(1000);
            }
        }
        public static void countDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(name + " " + i);
                Thread.Sleep(1000);
            }
        }
    }
   
}
