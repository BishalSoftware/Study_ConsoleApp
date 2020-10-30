using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = null; // heap memory with reference type can store 'null' but a stack memory with value type can't store 'null'

            Console.WriteLine("Is 's' NULL printed below?");
            Console.WriteLine(s);
            Console.WriteLine("Is 's'  NULL printed above?");
            Console.WriteLine("++++++++++");

            int? a = null; //to make value type 'null' we add '?' because null can be passed to value type from external source file
            Console.WriteLine("Is 'a' NULL printed below?");
            Console.WriteLine(a);
            Console.WriteLine("Is 'a' NULL printed above?");
            Console.WriteLine("++++++++++");

            int? b = a ?? 20;
            Console.WriteLine("When a is NULL, b= "+b);
            Console.WriteLine("++++++++++");

            int? a1 = 10;
            Console.WriteLine("When a1 is NOT NULL, a1= "+ a1);
            Console.WriteLine("++++++++++");

            int? b1 = a1 ?? 20;
            Console.WriteLine("When a1 is NOT NULL,b1= " + b1);
        }
    }
}


