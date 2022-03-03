using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncDemo_II
{
    internal class Program
    {
        static void Main(string[] args)
        {




            ProcessIAsync();
            ProcessIIAsync();
          
   

            Console.ReadLine();
        }
        //This is how me make our method async without calling Task task1 = Task.Run(ProcessI)
        static async Task ProcessIAsync()
        {

           await Task.Run(() =>
            {
                Console.WriteLine($"Process I is running... Thread No : {Thread.CurrentThread.ManagedThreadId}");
            });
        }

        static async Task ProcessIIAsync()
        {
            await Task.Run(() => 
            {
                Console.WriteLine($"Process II is running... Thread No : {Thread.CurrentThread.ManagedThreadId}");

            });
        }
    }
}
