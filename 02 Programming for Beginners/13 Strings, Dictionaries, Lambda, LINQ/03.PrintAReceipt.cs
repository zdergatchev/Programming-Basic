using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _03.PrintAReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            //int number = 42;
            //System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-CA");
            //var str = string.Format("The digit is: {0:f2}", number);
            //Console.WriteLine(number.ToString("D2"));
            //Console.WriteLine("Date is: {0:d.MM.yyyy HH:mm:ss}", DateTime.Now);

            var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            Console.WriteLine(@"/----------------------\");
            foreach (var num in nums)
            {
                Console.WriteLine("| {0,20:f2} |", num);
            }
            Console.WriteLine(@"|----------------------|");
            Console.WriteLine("| Total:{0,14:f2} |", nums.Sum());
            Console.WriteLine(@"\----------------------/");
        }
    }
}
