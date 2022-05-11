using System;
using System.Threading;
namespace Threading2
{
    public class Program
    {
        static async void Main()
        {
            Task<int> taskResult = MethodAsync();
            for (int i = 0; i < 5; i++)
            {
                PrintWriteLine($"B{i}");
                Task.Delay(2000).Wait();
            }
           
            Console.WriteLine("Waiting for MethodAsync to Finish");
            int k = await taskResult;
            
            Console.WriteLine(k);
            Console.Read();

        }

        public static async Task<int> MethodAsync()
        {
            for(int i = 0; i < 5; i++)
            {
                PrintWriteLine($"A{i}");
                Task.Delay(2000).Wait();
            }
            int result = 123;
            Console.WriteLine($"It returns {result}");

            return result;
        }
        static void PrintWriteLine(string msg)
        {
            int threadId = Thread.CurrentThread.ManagedThreadId;
            Console.ForegroundColor = threadId == 1 ? ConsoleColor.Green : ConsoleColor.Red;
            string tab = new string(' ', 27 - msg.Length);
            Console.WriteLine("{0}{1}Thread{2}", msg,tab,threadId);
        }
    }
}