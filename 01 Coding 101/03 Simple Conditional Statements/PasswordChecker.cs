﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class Program
    {
        static void Main(string[] args)
        {       
                var inputPassword = Console.ReadLine();
                string password = "s3cr3t!P@ssw0rd";

                if (inputPassword == password)
                {
                    Console.WriteLine("Welcome");
                }
                else
                {
                    Console.WriteLine("Wrong password!");
                }

            }
        }
}
