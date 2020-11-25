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
            // Loops - Iteration Statement
            // Iterates the set of statements repeatedly
            // Number of iterations depend on the condition
            // If condition is true, iteration continues and the program is in loop
            // If condition is false, iteration discontinues and the loop is exited 
            // Iteration statement can be classified as : for loop, while loop, do while loop, for each loop

            // "for" loop is used when number of iterations are known
            //  for (init; condition; increment)
            // {
            //   conditional code;
            // }


            // "for" loop
            // Display number from 1 to 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("i= " + i);
            }

            //"for" loop
            // Display total sum of number from 1 to 10
            Console.WriteLine("\nDisplay total sum of number from 1 to 10");
            int sum_one = 0;
            for (int i_one = 1; i_one <= 10; i_one++)
            {
                Console.WriteLine(i_one);
                sum_one = sum_one + i_one;
            }
            Console.WriteLine("-------------");
            Console.WriteLine(sum_one);

            //"for" loop
            // Display total sum of number from 1 to 10 for even numbers
            Console.WriteLine("\nDisplay total sum of number from 1 to 10 for even numbers");
            int sum_two = 0;
            for (int i_two = 1; i_two <= 10; i_two++)
            {
                if (i_two % 2 == 0)
                {
                    Console.WriteLine(i_two);
                    sum_two = sum_two + i_two;
                }
            }
            Console.WriteLine("-------------");
            Console.WriteLine(sum_two);

            // "for" loop
            // Display total sum of number from 1 to 10 for odd numbers
            Console.WriteLine("\nDisplay total sum of number from 1 to 10 for odd numbers");
            int sum_three = 0;
            for (int i_three = 1; i_three <= 10; i_three++)
            {
                if (i_three % 2 != 0)
                {
                    Console.WriteLine(i_three);
                    sum_three = sum_three + i_three;
                }
            }
            Console.WriteLine("-------------");
            Console.WriteLine(sum_three);

            // incremental "for" loop
            // Display number from 1 to 10
            Console.WriteLine("\nDemonstrating incremental 'for' loop");
            for (int i_four = 1; i_four <= 10; i_four++)
            {
                Console.WriteLine(i_four);
            }

            // decremental "for" loop
            // Display number from 10 to 1
            Console.WriteLine("\nDemonstrating decremental 'for' loop");
            for (int i_five = 10; i_five >= 1; i_five--)
            {
                Console.WriteLine(i_five);
            }

            // using 'for' loop to find whether the input number is prime number or not a prime number
            Console.WriteLine("\nPlease Enter an integer to find whether it is prime number or not a prime number: ");
            var value = Console.ReadLine();
            int num;

            if (int.TryParse(value, out num))
            {

                bool isprime = true;
                for (int i_six = 2; i_six <= Math.Sqrt(num); i_six++)
                {
                    if (num % i_six == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true && num != 0)
                    Console.WriteLine("Number is PRIME");
                else
                    Console.WriteLine("Number is NOT a PRIME number");
            }
            else
            {
                Console.WriteLine("You didn't enter an integer.");
            }

            //using 'for' loop to find prime number from 1 to 100
            Console.WriteLine("\nFinding primenumber from 1 to 100");
            for (int num_one = 1; num_one <= 100; num_one++)
            {
                bool isprime_one = true;
                for (int i_seven = 2; i_seven <= Math.Sqrt(num_one); i_seven++)
                {
                    if (num_one % i_seven == 0)
                    {
                        isprime_one = false;
                        break;
                    }
                }
                if (isprime_one)
                {
                    Console.Write(num_one + "\t");
                }
            }

            // 'while' loop
            // Repeatedly executes statements as long as a given condition is true

            //'while' loop
            // Obtaining upto 100th prime number
            Console.WriteLine("\n\nFinding primenumber upto 100th prime number");
            int count = 0;
            int num_two = 1;
            bool isprime_two;
            while (count < 100)
            {
                isprime_two = true;
                for (int j_two = 2; j_two <= Math.Sqrt(num_two); j_two++)
                {
                    if (num_two % j_two == 0)
                    {
                        isprime_two = false;
                        break;
                    }
                }
                if (isprime_two == true)
                {
                    Console.Write(num_two + "\t");
                    count++;
                }

                num_two++;
            }


            //'while' loop
            Console.WriteLine("\n\nPlease enter an integer to find out count of its digit : ");
            var value_three = Console.ReadLine();
            int num_three;
            if (int.TryParse(value_three, out num_three))
            {
                int temp_three = num_three;
                int digits_three = 0;
                while (temp_three != 0)
                {
                    digits_three++;
                    temp_three = temp_three / 10;
                }
                Console.WriteLine("{0} is {1} digit number", num_three, digits_three);
            }
            else
            {
                Console.WriteLine("You didn't enter an integer.");
            }

            //do while
            //Checks its condition at the end of the loop
            //do...while loop is guaranteed to execute at least one time

            int actual_pin = 9001;
            int count_two = 0;
            //pin of credit/debit card is four digit number
            int entered_pin;

            do
            {
                Console.WriteLine("Please your the pin of your card: ");
                entered_pin = int.Parse(Console.ReadLine());
                count_two++;
            } while (entered_pin != actual_pin && count_two < 3);

            if (entered_pin == actual_pin)
            {
                Console.WriteLine("Welcome User");
            }
            else
            {
                Console.WriteLine("Account Locked");
            }

            // Jump statement
            // Used to jump in a particular position in a program
            // Jump statement is classified as: Break, Continue, Goto, Return

            // Jump statement: Break
            // 'Break' is used to terminate the 'loop' and 'switch' statement
            Console.WriteLine("\nTerminate the loop before printing Number = 5");
            for (int i_eight = 1; i_eight <= 10; i_eight++)
            {
                if (i_eight == 5)
                {
                    break;
                }
                Console.WriteLine("Number = " + i_eight);
            }

            // Jump statement: Continue
            // 'Continue' forces the next iteration of 'loop' to take place, skipping any code in between
            Console.WriteLine("\nSkip to print Number 5 as well as 9 in the loop");
            for (int i_nine = 1; i_nine <= 10; i_nine++)
            {
                if (i_nine == 5 || i_nine == 9)
                {
                    continue;
                }
                Console.WriteLine("Number = " + i_nine);
            }


            // Jump statement: Goto
            // 'Goto' provides an unconditional jump from the 'goto' to a labeled statement in the same function
            Console.WriteLine("\nGoto is not preferred for use but there is a provision to use goto");
            int i_ten = 1;
        abc:
            Console.WriteLine(i_ten);
            i_ten++;
            if (i_ten <= 10)
            {
                goto abc;
            }

            // Jump statement: Return
            // Return terminates the method; in this example, main method is terminated.
            Console.WriteLine("\nDemonstrating Arithematic Division");
            Console.WriteLine("Enter the numerator integer number: ");
            int num_four = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the denominator integer number: ");
            int num_five = int.Parse(Console.ReadLine());

            if (num_five == 0)
            {
                Console.WriteLine("Cannot divide denominator by 0");
                Console.WriteLine("\nPress any key to terminate...");
                Console.ReadLine();
                return;
            }

            int result = num_four / num_five;
            Console.WriteLine("The result considering only integer part is: " + result);


            Console.WriteLine("\nPress any key to continue...");
            Console.ReadLine();
        } // End of Main method
    } // End of class 'Program'
}//End of namespace 'Study_ConsoleApp'




