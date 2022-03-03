using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Thread No : {Thread.CurrentThread.ManagedThreadId}");


            //Task task1 = Task.Factory.StartNew(ProcessI);
            //ProcessII();

            //Task task1 = new Task(ProcessI);
            //task1.Start();
            //ProcessII();

            //Task task1 = Task.Run(ProcessI);
            //ProcessII();

            //All above piece of code runs our Method as Async but always ProcessII runs first cause codes flow down very fast main thread doesnt wait until Task create new instance in the memory instead finish its thread then continue with its 

            //Task task1 = Task.Run(() =>
            //{
            //    ProcessI();
            //    ProcessII();
            //});

            //Above piece of code runs our Method as Async and create new Thread channel but First ProcessI runs until it finished then ProcessII runs

            Task task1 = Task.Run(ProcessI);
            task1.Wait();
            ProcessII();



            Console.ReadLine();
        }

        static void ProcessI()
        {
            Console.WriteLine("Process I is running...");
            Console.WriteLine($"Thread No : {Thread.CurrentThread.ManagedThreadId}");

        }

        static void ProcessII()
        {
            Console.WriteLine("Process II is running...");
            Console.WriteLine($"Thread No : {Thread.CurrentThread.ManagedThreadId}");

        }

    }
}
