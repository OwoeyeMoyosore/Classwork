using System;
using System.Threading;
using System.Threading.Tasks;

namespace CyberThreading
{ 
    
    public class Program
    {
        static void Main()
        { 
            //Console.BackgroundColor = ConsoleColor.White;
            //var task = new Task(DoWork);

            var task2 = new Task(delegate { DoWork(); });

            var task3 = new Task(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write(i);
                }

            });

            task3.Start();
            //Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
           
            Console.WriteLine("End of Main......");
            Console.Read();

        }

        public async static Task DoWork()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.Write(i);
            }
        }

        //public async Task<int> Add()
        //{

        //}

        public async Task DoWorkAsync()
        {

        }
    }
}

