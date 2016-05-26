using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.EnterEvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            
            while (true)
            {

                Console.Write("Enter even number: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("Even number entered: " + n);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even.");                        
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");                    
                }
                
            }
           // Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
