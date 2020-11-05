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
            // Demostrating Arithematic Operators
            Console.WriteLine("+++++++Arithematic Operator+++++++");
            int a = 50, b = 10;
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
            Console.WriteLine("Addition of a and b = "+ (a + b)); // addition arithematic operator
            Console.WriteLine("Subtraction of a and b = "+(a - b)); // subtraction arithematic operator
            Console.WriteLine("Multiplication of a and b = " + (a * b)); // multiplication arithematic operator
            Console.WriteLine("Division of a and b = " + (a / b)); // division arithematic operator, the variable is integer right now.
            Console.WriteLine("Modulus (Remainder) of a and b = " + (a % b)); // modulus (remainder) arithematic operator

            /*
             * Operator precedence and associativity
             * The following list orders arithmetic operators starting from the highest precedence to the lowest:

                    Postfix increment x++ and decrement x-- operators
                    Prefix increment ++x and decrement --x and unary + and - operators
                    Multiplicative *, /, and % operators
                    Additive + and - operators
                    Binary arithmetic operators are left-associative. That is, operators with the same precedence level are evaluated from left to right.

             * Use parentheses, (), to change the order of evaluation imposed by operator precedence and associativity.
            */


            int c = 5;
            Console.WriteLine("\nc= " + c);
            int d = a + b * c; //Multiple operator has higher precedance than addition operator.
            Console.WriteLine("Demonstrating default precedence between multiplication and addition (a+b*c)= "+d);
            int d1 = a + (b * c); //Multiple operator has higher precedance than addition operator. I have used parenthesis to define precedence manually.
            Console.WriteLine("Enforcing precedence manually using parenthesis [a+(b*c)]= " + d1);
            int d2 = (a + b) * c; //I have used parenthesis to define precedence manually.
            Console.WriteLine("Enforcing precedence manually using parenthesis [(a+b)*c]= " + d2+ "\n");

            int marks = 72, max = 80;
            Console.WriteLine("marks= " + marks + "\nmax= " + max + "\n");
            int perc = marks / max * 100; // Division and Mulitplication have same default precedance in c#
            Console.WriteLine("The percentage in integer format (operators with the same precedence level are evaluated from left to right.): " + perc+ "\n");
            //Moving 100 to left to multiply first instead of division to change the result.// associativity is from left to right for same precedence for binary arithmetic operators.
            int perc1 = marks * 100 / max;
            Console.WriteLine("Again,with same marks and max, the percentage in integer format: " + perc1 + "\n");

            //Compound Assignment
            int aa = 10;
            aa = aa + 5;
            Console.WriteLine("Without compound assignment; When aa=10 and aa = aa + 5, then aa: " + aa + "\n");

            Console.WriteLine("Compound Assignment");

            int ab = 5;
            ab += 9;
            Console.WriteLine("When ab=5 and ab+=9, then a: " + ab);

            int bb = 14;
            bb -= 4;
            Console.WriteLine("Whne bb=14 and bb-=4, then bb: " + bb);

            int cb = 10;
            cb *= 2;
            Console.WriteLine("When cb=10 and cb*=2, then cb: " + cb);

            int db = 20;
            db /= 4;
            Console.WriteLine("When db=20 and db/=4, then db = " + db);

            int eb = 5;
            eb %= 3;
            Console.WriteLine("When eb=5 and eb%=3, then eb: " + eb+ "\n");

            Console.WriteLine("Unary increment/decrement operator");
            Console.WriteLine("postfix increment operator");
            int i = 3;
            Console.WriteLine("i = " + i +"\ni++ = " + i++ + "\ni = " + i+"\nHere, initially i = 3; " +
                " when i++ post-fix-increment is printed, firstly 'i' is printed/assigned, then only +1 increment is done, so i++=3 ;" +
                " after print/assignment is done, i becomes i=i+1=4, so i=4 now.");
            Console.WriteLine("i++ is still 3 at first because i is first printed/assigned and then added only  +1 (post-fix-increment); after i++ is printed, i becomes 4\n");
            
            int ia = 10;
            int ib = ia++;
            Console.WriteLine("Here, ia=10 and ib=ia++; " +
                "ib is assigned ia(before addition) for ib=ia++ (post-fix addition) i.e. ia is still ia (and not ia +1) so ib = ia(before addition), hence ib is: " + ib + "; " +
                "After operation ib=ia++ is completed and ib becomes ia (before addition) i.e.ib=10, ia is added + 1 so ia = ia +1 for ia++ . Now, ia is: " + ia);
            Console.WriteLine("After operation, ib: " + ib + " ,  ia: " + ia);

            
            Console.WriteLine("\nprefix increment operator");
            int j = 3;
            Console.WriteLine("j = {0}\n++j = {1}\nj = {2}", j, ++j, j+"\nHere, initially j=3;" +
                " when ++j pre-fix-increment is printed, firstly 'j' is increment with +1 before printed/assigned, so j=1+j=4 , hence ++j=4 ;" +
                " after print/assignment is done, j is already 1+j so j=4 now.");

            int ja = 10;
            int jb = ++ja;
            Console.WriteLine("\nHere, ja=10 and jb=++ja;" +
                "jb is assigned ++ja(addition is done before assiged/print) for jb=ja++ (pre-fix-addition) i.e. ja is ++ja so jb = ++ja =1+ja(after addition), hence jb is: " + jb + "; " +
                "After operation jb=++ja is completed, jb is already +jaa=1+ja (addition is done before assigned/print) i.e.jb=11.So, ja is already: " + ia);
            Console.WriteLine("Before jb is printed,ja is already 1+ja=11, so ja is: " + ja + "; When jb is printed, then jb is: " + jb+ "; Now, ja is already: "+ja);

            Console.WriteLine("\npostfix decrement operator");
            int k = 3;
            Console.WriteLine("k = {0}\nk-- = {1}\nk = {2}", k, k--, k);

            Console.WriteLine("\nprefix decrement operator");
            int l = 3;
            Console.WriteLine("l = {0}\n--l = {1}\nl = {2}\n",l, --l, l);

            Console.WriteLine("+++++++Comparision Operator+++++++");
            int comp_a = 50, comp_b = 20;
            Console.WriteLine("comp_a: " + comp_a + " comp_b: " + comp_b);
            Console.WriteLine("comp_a is greater than comp_b i.e. comp_a > comp_b : " + (comp_a > comp_b));
            Console.WriteLine("comp_a is lesser than comp_b i.e. comp_a < comp_b : " + (comp_a < comp_b));
            Console.WriteLine("comp_a is greater than or equal to comp_b i.e. comp_a >= comp_b : " + (comp_a >= comp_b));
            Console.WriteLine("comp_a is lesser than or equal to comp_b i.e. comp_a <= comp_b : " + (comp_a <= comp_b));
            Console.WriteLine("comp_a is equal to comp_b i.e. comp_a == comp_b : " + (comp_a == comp_b));
            Console.WriteLine("comp_a is not equal to comp_b i.e. comp_a != comp_b : " + (comp_a != comp_b));

            Console.WriteLine("\nDouble.NaN is greater than comp_b i.e. Double.NaN > comp_b : " + (Double.NaN > comp_b));
            Console.WriteLine("Single.NaN is greater than comp_b i.e. Single.NaN > comp_b : " + (Single.NaN > comp_b));

            Console.WriteLine("\n+++++++ Boolean Logical Operator +++++++");

            //The conditional operator ?:, also known as the ternary conditional operator, evaluates a Boolean expression
            Console.WriteLine("The conditional operator ?:, also known as the ternary conditional operator, evaluates a Boolean expression");
            int num = 47;
            string s1 = num % 2 == 0 ? "Even" : "Odd"; // first operand 'num%2 == 0' is boolean; if true, s1= second operand 'Even'; if false, s1=third operand 'Odd'
            Console.WriteLine("Demonstrating (ternary) conditional operator ?:  s1 is equal to  "+s1);

            int numb = 48;
            string s2 = numb % 2 == 0 ? "Even" : "Odd";
            // first operand 'numb%2 == 0' is boolean; if true, s2= second operand 'Even'; if false, s2=third operand 'Odd'
            Console.WriteLine("Demonstrating (ternary) conditional operator ?:  s2 is equal to  " + s2);

            /*
            #The following operators perform logical operations with bool operands:
            1. Unary ! (logical negation) operator.
            2. Binary & (logical AND), | (logical OR), and ^ (logical exclusive OR) operators. Those operators always evaluate both operands.
            3. Binary && (conditional logical AND) and || (conditional logical OR) operators. 
            Those operators evaluate the right-hand operand only if it's necessary.
            
            #For operands of the integral numeric types, the &, |, and ^ operators
            perform bitwise logical operations. For more information, see Bitwise and shift operators.
            */

            bool passed = true;
            Console.WriteLine("\npassed = " + passed);
            Console.WriteLine("Demonstrating Unary !(logical negation) operator  '!passed' = " + !passed);
            Console.WriteLine("Demonstrating Unary !(logical negation) operator  '!true' = " + !true);

            Console.WriteLine("\nConditional Logical AND");
            Console.WriteLine("true && true = " + (true && true));
            Console.WriteLine("true && false = " + (true && false));
            Console.WriteLine("false && true = " + (false && true));
            Console.WriteLine("false && false = " + (false && false));
            Console.WriteLine("false && false = " + (false && false) + "\n");

            Console.WriteLine("Logical AND with 'null' because Conditional Logical AND can't be used");
            Console.WriteLine("true & null = " + (true & null));
            Console.WriteLine("false & null = " + (false & null) +"\n");


            string username = "programmer";
            string password = "learn";
            Console.WriteLine((username=="programmer" && password=="learn") ? "Welcome User" : "Invalid User");
            string valid;
            valid = (username == "programmer" && password == "bug") ? "Welcome User" : "Invalid User";
            Console.WriteLine(valid);
            
            Console.WriteLine("\nConditional Logical OR");
            Console.WriteLine("true || true = " + (true || true));
            Console.WriteLine("true || false = " + (true || false));
            Console.WriteLine("false || true = " + (false || true));
            Console.WriteLine("false || false = " + (false || false));

            Console.WriteLine("\nLogical OR with 'null' because Conditional Logical OR can't be used");
            Console.WriteLine("true | null = " + (true | null));
            Console.WriteLine("false | null = " + (false | null));

            Console.WriteLine("\nLogical exclusive OR operator");
            Console.WriteLine("true ^ true = " + (true ^ true));
            Console.WriteLine("true ^ false = " + (true ^ false));
            Console.WriteLine("false ^ true = " + (false ^ true));
            Console.WriteLine("false ^ false = " + (false ^ false));

            Console.WriteLine("\nLogical exclusive OR operator with 'null' ");
            Console.WriteLine("true ^ null = " + (true ^ null));
            Console.WriteLine("false ^ null = " + (false ^ null));
           // Console.WriteLine("null ^ null = " + (null ^ null));
        }
    }
}



