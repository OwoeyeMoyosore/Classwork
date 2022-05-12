using System;
using System.Text;
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

            ////File
            //string[] words = { "This is a ball", "This is a house", "Set to Chalk", "micess" };
            //string path = @"C:\Users\user\new text document.txt";
            //string path2 = @"C:\Users\user\testttt.docx";
            //File.WriteAllLines(path, words);
            //File.WriteAllLines(path2, words);

            //foreach(var item in File.ReadAllLines(path))
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in File.ReadAllLines(pathss))
            //{
            //    Console.WriteLine(item);
            //}

            //Fileinfo
            //string path3 = @"C:\Users\user\new text document.txt";
            //DirectoryInfo dirr = new DirectoryInfo(@"C:\Users\user\OneDrive\Desktop\ui");
            //FileInfo [] textfile = dirr.GetFiles("*.jpg",SearchOption.AllDirectories);
            //Console.WriteLine("matches: {0}", textfile.Length);
            //foreach(var item in textfile)
            //{
            //    Console.WriteLine(item.FullName);
            //    Console.WriteLine(item.CreationTime);
            //}

            //Writeforall();
            Readforall();

            //Filestream WRITE
            string path4 = @"C:\Users\user\New Text Document.txt";
            var fs = new FileStream(path4, FileMode.Open);
                    //FileStream fs = File.Open(path4, FileMode.Create);
            string newword = "this is a brand new carssss";

            //When you want to write, you convert to byte
            byte[] writing = Encoding.Default.GetBytes(newword);
            fs.Write(writing, 0, writing.Length);
            //fs.Close();
            fs.Position = 0;
           
            
            //fs.Close();
            //FILESTREAM READ
            //byte[] reading = new byte[writing.Length];
            //for (int i = 0; i < writing.Length; i++)
            //{
            //    reading[i] = (byte)fs.ReadByte();
            //}
            //Console.WriteLine(Encoding.Default.GetString(reading));
            //fs.Close();

            int j = 0;
            while ((j = fs.ReadByte()) != -1)
            {
                Console.Write((char)j);
            }
            fs.Close();

        }


    
         
        //Stream Writer
        //public static void Writeforall()
        //{
           
        //    StreamWriter sw = new StreamWriter(@"C:\Users\user\New Text Document.txt");
        //    sw.WriteLine("welcome to cyberspace");
        //    sw.WriteLine("pleasure to meet you hello");
        //    sw.Close();

        //}

        public static void Readforall()
        {
            StreamReader sr = new StreamReader(@"C:\Users\user\New Text Document.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }

        



    }
}

