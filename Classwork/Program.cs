using System;
using System.Linq;
using System.Collections.Generic;
namespace Classworks
{
    public class Program
    {
        
      
        
        static void Main()
        {
          
            var accounts = Account.GetAccounts();
            var sumamount = accounts.Sum(x => x.Amount);
            Task.Run(() => Console.WriteLine($"The sum is {sumamount}"));
            Console.ReadLine();

            Console.WriteLine("The List of names are: ");
            var names = accounts.Select(x => x.Name);
            foreach(var name in names)
            {
                Task.Run(() => Console.WriteLine(name));
            }
            Console.ReadLine();



            Console.WriteLine($"Days in ascending Order ");
            string[] weekdays = {"Monday", "Tuesday", "Wednesday","Thursday","Friday","Saturday","Sunday"};
            var ascend = weekdays.OrderBy(x => x);
            foreach (var day in ascend)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("\n Months of the Year");
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            var descend = months.OrderBy(x => x);
            foreach(var m in descend)
            {
                Console.WriteLine(m);
            }
               
            Console.WriteLine("\n Last two months");
      //    var twolastmonths = descend.Reverse().Take(2).Reverse().ToArray();
            var twoo = descend.TakeLast(2);
            foreach (var m in twoo)
            {
                Console.WriteLine(m);
            }
                
          

        }

    }
    public class Account
    {
        public decimal Amount { get; set; }
        public string Gender { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string yearofspecification { get; set; }
        public string Days { get; set; }

        public static List<Account> GetAccounts()
        {
            return new List<Account>
            {
                new Account(){ Id = 2, Name = "Amar", Gender= "F" , Amount =400_000, yearofspecification = "2 years" },
                new Account(){ Id = 6, Name = "Joe", Gender= "M" , Amount =40_000, yearofspecification = "2 months" },
                new Account(){ Id = 8, Name = "Tola", Gender= "F" , Amount =800_000, yearofspecification = "5 days" },
                new Account(){ Id = 10, Name = "Jude", Gender= "M" , Amount =500_000, yearofspecification = "6 years" },
                new Account(){ Id = 12, Name = "Amir", Gender= "F" , Amount =1_000_000, yearofspecification = "1 year" },
                new Account(){ Id = 14, Name = "Sam", Gender= "F" , Amount =600_000, yearofspecification = "1 year" },
                new Account(){ Id = 16, Name = "Joy", Gender= "F" , Amount =100_000, yearofspecification = "3 years" },
                new Account(){ Id = 18, Name = "Ola", Gender= "M" , Amount =20_000, yearofspecification = "4 months" },
            };
        }

        public static List<Account> GetDays()
        {
            return new List<Account>
            {
                new Account{Days = ""}

            };
        }
    }
}

