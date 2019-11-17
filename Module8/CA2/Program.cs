/*
Author: Richard Mora
Date: 11/16/2019
CTEC 135: Microsoft Software Development with C#
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CA2 
{
    class Program
    {
        static void Main(string[] args)
        {
            // string s;
            // s = ReadLine();
            // WriteLine(s);
            WriteLine("CA2 project");
            string arg;
            arg = ReadLine();
            while (arg != null)
            {
                WriteLine(arg);
                arg = ReadLine();
            }
        }
    }
}
