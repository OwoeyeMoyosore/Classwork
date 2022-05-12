using System;
//using System.IO;
namespace Fileinfo
{
    public class Program
    {
        static void Main()
        {
            //DirectoryInfo
            DirectoryInfo dir = new DirectoryInfo(".");
            DirectoryInfo direc = new DirectoryInfo(@"C:\Users\user\OneDrive\Documents");
            Console.WriteLine(direc.Name);
            Console.WriteLine(direc.FullName);
            Console.WriteLine(direc.Parent);
            Console.WriteLine(direc.CreationTime);
            Console.WriteLine(dir.Name);
            Console.WriteLine(dir.FullName);

            //File
            string[] words = { "This is a ball", "This is a house", "Set to Chalk", "micess" };
            string path = @"C:\Users\user\new text document.txt";
            string path2 = @"C:\Users\user\testttt.docx";
            File.WriteAllLines(path, words);
            File.WriteAllLines(path2, words);

            foreach(var item in File.ReadAllLines(path))
            {
                Console.WriteLine(item);
            }
            //foreach (var item in File.ReadAllLines(pathss))
            //{
            //    Console.WriteLine(item);
            //}

            //Fileinfo
            string path3 = @"C:\Users\user\new text document.txt";
            DirectoryInfo dirr = new DirectoryInfo(@"C:\Users\user\OneDrive\Desktop\ui");
            FileInfo [] textfile = dirr.GetFiles("*.jpg",SearchOption.AllDirectories);
            Console.WriteLine("matches: {0}", textfile.Length);
            foreach(var item in textfile)
            {
                Console.WriteLine(item.FullName);
                Console.WriteLine(item.CreationTime);
            }
        }
    }
}
