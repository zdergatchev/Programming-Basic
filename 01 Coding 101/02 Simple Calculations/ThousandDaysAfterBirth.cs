using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThousandDaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "dd-MM-yyyy";
            string value = Console.ReadLine();
            DateTime userBirthday = DateTime.ParseExact(value, data, null);
            Console.WriteLine(userBirthday.AddDays(999).ToString("dd-MM-yyyy"));
        }       
    }
}