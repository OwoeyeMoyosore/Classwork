using System;
namespace Attributes
{
    public class Program
    {
        public static void Main()
        {
            var total = calculator.Add(50, 50);
            Console.WriteLine(total);
            var subtotal = calculator.Add(new List<int> { 2, 49, 67, 89, 900, 343, 28 });
            Console.WriteLine(subtotal);
        }
    }
    public class calculator
    {  
        [Obsolete("use :Add(List<int> numbers) method ")]
        public static int Add(int first, int second) => first + second;
        
        //public static int Add(int first, int second)
        //{
        //    Console.WriteLine("Method outdated");
        //    return first + second;
        //}
        public static int Add(List<int> numbers)
        {
            Console.WriteLine("new method");
            int result = 0;
            foreach (var number in numbers)
            {
                result = result + number;
            }
            return result;
        }
    }

}


