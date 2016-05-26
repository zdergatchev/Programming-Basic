using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelsSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowels = Console.ReadLine().ToLower();
            var sum = 0;
            for (int i = 0; i < vowels.Length; i++)
            {
                if (vowels[i] == 'a')
                {
                    sum = sum + 1;
                }
                else if (vowels[i] == 'e')
                {
                    sum = sum + 2;
                }
                else if (vowels[i] == 'i')
                {
                    sum = sum + 3;
                }
                else if (vowels[i] == 'o')
                {
                    sum = sum + 4;
                }
                else if (vowels[i] == 'u')
                {
                    sum = sum + 5;
                }
            }
            Console.WriteLine("{0}", sum);
        }
    }
}
