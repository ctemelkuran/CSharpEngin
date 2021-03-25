﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] students = new string[3] { "Çığır", "Fatma", "Zeytin" };
                students[3] = "Arven";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
            

            Console.ReadLine();
        }
    }
}
