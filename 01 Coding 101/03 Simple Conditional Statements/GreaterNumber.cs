using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = int.Parse(Console.ReadLine());
            var num = double.Parse(Console.ReadLine());
            if (grade > num)
            {
                Console.WriteLine("{0}", grade);
            }
            else
            {
                Console.WriteLine("{0}", num);
            }
        }
    }
}
