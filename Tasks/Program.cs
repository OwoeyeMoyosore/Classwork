using System;
using System.Threading;
//using System.IO;
namespace Taskss
{
    public class Program
    {

        public /*async*/ static /*Task*/ void Main()
        {
            //    await Task.Run(() => First());
            //    await Task.Run(() => Second());

            Task.Run(() => First());
            Task.Run(() => Second());
            Console.Read();
        
        }
        public static int First()
        {
            Thread.Sleep(2000);
            int result = 5 * 8;
            Console.WriteLine($"The result is {result}");
            return result;
        }
            
            
        public static int Second()
        {

                int result1 = 5 + 8;
                Console.WriteLine($"The result is {result1}");
                return result1;
         
        }
    }
    
       
        
      

        //public async static Task <int> First()
        //{
        //    Thread.Sleep(2000);
        //    int result =5 * 8;
        //    Console.WriteLine($"The result is {result}");
        //    return result;
            
        //}
        //public async static Task<int> Second()
        //{
        //    int result1 = 5 + 8;
        //    Console.WriteLine($"The result is {result1}");
        //  return result1;
            
        //}
       
    

}
//Task[] t = new Task[2];
//string[] files = null;
//string[] dir = null;


//string docdirectory = Environment.GetFolderPath(Environment.SpecialFolder.System);
//t[0] = Task.Factory.StartNew(() => files = Directory.GetFiles(docdirectory));
//t[1] = Task.Factory.StartNew(() => dir = Directory.GetDirectories(docdirectory));


// Task.Factory.ContinueWhenAll(t, completedfile =>
//{

//    Console.WriteLine("{0} Contains ", docdirectory);
//    Console.WriteLine("{0} files", files.Length);
//    Console.WriteLine("{0} subdirectories" , dir.Length);
//});
////Console.ReadKey();

//Console.WriteLine("Enter your path");
//string path = Console.ReadLine();
////string path = @"C:\Users\user\OneDrive\Documents\newwww";
//if (Directory.Exists(path))
//{
//    Directory.Delete(path);
//    Console.WriteLine("DELETED");
//}
//else Console.WriteLine("File not found");


//public async static Task Main(string[] args)
//{
//    Console.WriteLine("Calculation Started");
//    await calculate();
//}
//public async static Task calculate()
//{
//    await Task.Run(() => 
//         calculate1());
//    await Task.Run(() => calculate2());
//    await Task.Run(() => calculate3());
//    //Console.Read();

//}
//public async static  Task<int> calculate1()
//{
//    Thread.Sleep(3000);
//    Console.WriteLine("Calculation 1 in progress");
//    return 500;
//}
//public async static Task<int> calculate2()
//{
//    Console.WriteLine("Calculation 2 in progress");
//    return 2100;
//}
//public async static Task<int> calculate3()
//{
//    Console.WriteLine("Calculation 3 in progress");
//    return 100;
//}

