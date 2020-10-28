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
            short num1 = 10;
            short num2 = 20;
            short sum = (short)(num1 + num2); //type casting: from bigger to smaller value
            Console.WriteLine(sum);

            double num3 = 1325423452344.23134123433F;
            double num4 = 99948484764567918.946356346543643563456345F;
            float mul = (float)( num3*num4);
            Console.WriteLine("The multiply and changing to float number= " + mul);

            int a = 10;
            object o = a; //boxing: copying from stack to heap
            Console.WriteLine("Printing object 'o' which has int 'a' value: " + o);

            int b = (int) o;  //unboxing: copying from heap to stack
            Console.WriteLine("Printing int b value which has object 'o' value(object has int datatype): " + b);

            object o1 = "This is String";
            int b1 = (int)o1; //there is no compile time error but there will be runtime error 
            Console.WriteLine("Printing int b value which has object 'o' value (object has string datatype): " + b1);
        }
    }
}
