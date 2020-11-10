using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_ConsoleApp
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
             * Control Statement: 
             * -Controls the flow of execution
             * -Enable statements to be executed on specific condition
             * -Enable statements to be executed repeatedly
             * -Enable to jump on a particular point in the code
             * 
             * Hence, control statement can be classified in:
             * -Conditional Statements or Selection statements
             * -Iteration Statements / Loops
             * -Jump Statements
             * ++++++++++++++++++++++++++++++++
             * 
             * Conditional Statement or Selection statements : Makes the execution of a particular block only when condition returns true.
             * 
             * 
             * Conditional (Selection) Statement can be classified as:
             * - if ... else ...
             * - switch 
             * ++++++++++++++++++++++++++++++++
             * 
             * - if Statements
             *  An 'if' statement can be followed by an optional 'else' statement.
             * 'else' executes when the Boolean expression is false.
             */

            // 'if' statement only
            Console.WriteLine("Please enter an integer number:");
            int num1 = int.Parse(Console.ReadLine());
            if (num1 %2 == 0)
            {
                Console.WriteLine("It is an even number");
            }


            // 'if - else' statement 
            Console.WriteLine("Please enter another integer number again:");
            int num2 = int.Parse(Console.ReadLine());
            if (num2 % 2 == 0)
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("It is an odd number");
            }

            // 'if - else if - else' statement
            Console.WriteLine("Enter your percentage in number:");
            float percent = float.Parse(Console.ReadLine());

            if (percent >= 80)
                Console.WriteLine("Grade A");

            else if (percent >= 60)
                Console.WriteLine("Grade B");

            else if (percent >= 40)
                Console.WriteLine("Grade C");

            else
                Console.WriteLine("Grade D");

            // more than one 'if' statement
            Console.WriteLine("Bug when 'else-if' is not used and only 'if' is used");
            Console.WriteLine("Enter your percentage in number:");
            float percent1 = float.Parse(Console.ReadLine());

            if (percent1 >= 80)
                Console.WriteLine("Grade A");

            if (percent1 >= 60)
                Console.WriteLine("Grade B");

            if (percent1 >= 40)
                Console.WriteLine("Grade C");

            else
                Console.WriteLine("Grade D");

            //Switch Statement
            /* Switch Statement
             * - Allows a variable to be tested for equality against a list of values in parallel so that performance (less time) is improved
             * - Each value is called a case
             * - Every 'case' and 'default' must be terminated by 'break' statement
             */

            Console.WriteLine("Please enter one character to find if it is a vowel: ");
            char ch = char.Parse(Console.ReadLine());
            string s = ch.ToString().ToLower();
            switch (s)
            {
                case "a":  // For string, " ". For char, ' '. For Number, quotation mark is not required.
                    Console.WriteLine("a is vowel");
                    break;
                case "e":
                    Console.WriteLine("e is vowel");
                    break;
                case "i":
                    Console.WriteLine("i is vowel");
                    break;
                case "o":
                    Console.WriteLine("o is vowel");
                    break;
                case "u":
                    Console.WriteLine("u is vowel");
                    break;
                default:
                    Console.WriteLine("The entered character is not a vowel");
                    break;
            }

             Console.WriteLine("Please enter another character to find if it is a vowel: ");
             char ch1 = char.Parse(Console.ReadLine());
                    string s1 = ch1.ToString().ToLower();
                    switch (s1)
                    {
                        case "a":                            
                        case "e":                           
                        case "i":                           
                        case "o":                           
                        case "u":
                            Console.WriteLine(s1+" is vowel");
                            break;
                        default:
                            Console.WriteLine("The entered character is not a vowel");
                            break;
                    }
        Console.ReadLine();
        }
    }
}



