using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MaxSequenceOfEqualElementsNEW
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            List<int> temp = new List<int>();
            List<int> result = new List<int>();

            temp.Add(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                    temp.Add(input[i]);
                    if (i == input.Length - 1)
                    {                        
                        if (temp.Count > result.Count)
                        {
                            result.Clear();
                            result.InsertRange(0, temp);
                        }
                    }
                }
                else
                {                    
                    if (temp.Count > result.Count)
                    {
                        result.Clear();
                        result.InsertRange(0, temp);
                    }
                    temp.Clear();
                    temp.Add(input[i]);                    
                }
            }
            Console.WriteLine("{0}", string.Join(" ", result));
        }
    }
}

