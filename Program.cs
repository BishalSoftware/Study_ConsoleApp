using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hello, ");
            //Console.Write("Hello, ");
            //Console.Write("Hello, \n");
            //Console.Write("Hello, \t\t");
            Console.WriteLine("Welcome to C#...");
            */

            const int a = 10;
            string s = "Studying C#";

            Console.WriteLine(a);
            Console.WriteLine(s);


            string name = "John";
            int age = 30;

            Console.WriteLine(name);
            Console.WriteLine(age);

            Console.WriteLine("User name is " + name);
            Console.WriteLine("User age is " + age);

            Console.WriteLine("User name is " + name + ", User age is " + age);

            Console.WriteLine("User name is " + name +  "\nUser age is " + age);

            Console.WriteLine("User name is {0}\nUser age is {1}",name, age);

            string name1 = Console.ReadLine();
            int age1 = int.Parse(Console.ReadLine());
            Console.WriteLine("User name is {0}\nUser age is {1}", name1, age1);


            Console.WriteLine("Enter User name");
            string name2 = Console.ReadLine();
            Console.WriteLine("Enter User age");
            int age2 = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("User name is {0}\nUser age is {1}", name2, age2);

        }
    }
}
