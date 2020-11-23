using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Study_ConsoleApp
{

    public static class DiceLibrary
    {
        //Random number generator to simulate dice rolls
        static Random rand = new Random();

        //Roll a single die
        public static int Roll()
        {
            return rand.Next(1, 7);
        } //End of method Roll()

        //Roll two dice
        public static List<object> Roll2()
        {
            var rolls = new List<object>();
            rolls.Add(Roll());
            rolls.Add(Roll());
            return rolls;
        } // End of method Roll2()

        //Calculate the sum of n dice rolls
        public static int DiceSum(IEnumerable<object> values)
        {
            var sum = 0; //assigning value 0 instead of assigning value through LINQ
            foreach (var item in values)
            {
                switch (item)
                {
                    // A single zero value
                    case 0:
                        break;
                    // A single value
                    case int val:
                        sum += val;
                        break;
                    // A non-empty collection
                    case IEnumerable<object> subList when subList.Any():
                        sum += DiceSum(subList);
                        break;
                    // An empty collection
                    case IEnumerable<object> subList:
                        break;
                    // A null reference
                    case null:
                        break;
                    // A value that is neither an integer nor a collection
                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }
            return sum;
        } // End of method DiceSum(IEnumerable<object> values)

        //Pass
        public static object Pass()
        {
            if (rand.Next(0, 2) == 0)  // (0,2) and not (1,7)
            {
                return null;
            }

            else
            {
                return new List<object>();
            }
        } //End of method Pass()

    } //End of class DiceLibrary

    public abstract class Shape
    {
        public abstract double Area { get; }
        public abstract double Circumference { get; }
    } // End of class Shape

    public class Rectangle : Shape
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length { get; set; }
        public double Width { get; set; }

        public override double Area
        {
            get { return Math.Round(Length * Width, 2); }
        }

        public override double Circumference
        {
            get { return ((Length + Width) * 2); }
        }
    } // End of class Rectangle : Shapee
    public class Square : Rectangle
    {
        public Square(double side) : base(side, side)
        {
            Side = side;
        }

        public double Side { get; set; }
    } // End of class Square : Rectangle

    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Radius { get; set; }

        public override double Area
        {
            get { return (Math.PI * Math.Pow(Radius, 2)); }
        }

        public override double Circumference
        {
            get { return (2 * Math.PI * Radius); }
        }
    } //End of class Circle : Shape

    public class Amoeba : Shape
    {
        public Amoeba(double pseudopods)
        {
            Pseudopods = pseudopods;
        }

        public double Pseudopods { get; set; }

        public override double Area
        {
            get { return (new Random().Next(1, 4)); }
        }

        public override double Circumference
        {
            get { return (new Random().Next(1, 3)); }
        }
    } //End of class Amoeba : Shape


    class Program
    {
        public enum Color { Red, Blue, Green }

        private static void ShowShapeInfo(Shape sh)
        {
            switch (sh)
            {
                case Shape shape when shape == null:  // Note that this code never evaluates to true.
                    Console.WriteLine($"An uninitiated shape (shape == null)");
                    break;
                case null:
                    Console.WriteLine($"An uninitialized shape");
                    break;
                case Shape shape when sh.Area == 0 && sh.Circumference == 0:
                    Console.WriteLine($"The shape: {sh.GetType().Name} with no dimensions");
                    break;
                case Square sq when sq.Area > 0:
                    Console.WriteLine("Information about square:");
                    Console.WriteLine($"  Length of a side: {sq.Side}");
                    Console.WriteLine($"  Area: {sq.Area}");
                    Console.WriteLine($"  Circumference: {sq.Circumference}");
                    break;
                case Rectangle r when r.Length == r.Width && r.Area > 0:
                    Console.WriteLine("Information about square rectangle:");
                    Console.WriteLine($"  Length of a side: {r.Length}");
                    Console.WriteLine($"  Area: {r.Area}");
                    Console.WriteLine($"  Circumference: {r.Circumference}"); //I added this statement
                    break;
                case Rectangle r when r.Area > 0:
                    Console.WriteLine("Information about rectangle:");
                    Console.WriteLine($"  Dimensions: {r.Length} x {r.Width}");
                    Console.WriteLine($"  Area: {r.Area}");
                    Console.WriteLine($"  Circumference: {r.Circumference}"); //I added this statement
                    break;
                case Shape shape when sh != null:
                    Console.WriteLine($"A {sh.GetType().Name} shape");
                    break;
                default:
                    Console.WriteLine($"The {sh.GetType().Name} variable does not represent a Shape."); //when does it execute ?
                    break;
            }
        }// End of method ShowShapeInfo(Shape sh)

        private static void ShowCollectionInformation_one(object coll)
        {
            switch (coll)
            {
                case Array arr:
                    Console.WriteLine($"An array with {arr.Length} elements.");
                    break;
                case IEnumerable<int> ieInt:
                    Console.WriteLine($"Average: {ieInt.Average(s => s)}");
                    break;
                case IList list:
                    Console.WriteLine($"{list.Count} items");
                    break;
                case IEnumerable ie:
                    string result = "";
                    foreach (var e in ie)
                        result += $"{e}";
                    Console.WriteLine(result);
                    break;
                case null:
                    // Do nothing for a null
                    break;
                default:
                    Console.WriteLine($"A instance of type {coll.GetType().Name}");
                    break;
            }
        } //End of method ShowCollectionInformation_one(object coll)

        private static void ShowCollectionInformation_two<T>(T coll)
        {
            switch (coll)
            {
                case Array arr:
                    Console.WriteLine($"An array with {arr.Length} elements.");
                    break;
                case IEnumerable<int> ieInt:
                    Console.WriteLine($"Average: {ieInt.Average(s => s)}");
                    break;
                case IList list:
                    Console.WriteLine($"{list.Count} items");
                    break;
                case IEnumerable ie:
                    string result = "";
                    foreach (var e in ie)
                        result += $"{e} ";
                    Console.WriteLine(result);
                    break;
                case object o:
                    Console.WriteLine($"A instance of type {o.GetType().Name}");
                    break;
                default:
                    Console.WriteLine("Null passed to this method.");
                    break;
            }
        } //End of method void ShowCollectionInformation_two<T>(T coll)


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
            if (num1 % 2 == 0)
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

            if (percent > 100)
            {
                Console.WriteLine("Percentage cannot be greater than 100");
            }

            else if (percent >= 80)
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

            if (percent > 100)
            {
                Console.WriteLine("Percentage cannot be greater than 100");
            }

            if (percent1 >= 80)
                Console.WriteLine("Grade A");

            if (percent1 >= 60)
                Console.WriteLine("Grade B");

            if (percent1 >= 40)
                Console.WriteLine("Grade C");

            else
                Console.WriteLine("Grade D");



            //nested if 

            // In the following example, Result1 appears if both m > 10 and n > 20 evaluate to true. 
            // If m > 10 is true but n > 20 is false, Result2 appears.

            int m = 12;
            int n = 18;

            if (m > 10)
            {
                if (n > 20)
                {
                    Console.WriteLine("Result1");
                }
                else
                {
                    Console.WriteLine("Result2");
                }
            }


            //If, instead, you want Result2 to appear when (m > 10) is false:

            if (m > 10)
            {
                if (n > 20)
                {
                    Console.WriteLine("Result_one");
                }
            }
            else

            {
                Console.WriteLine("Result_two");
            }

            //Using "Nested if" to determine whether the input character is an alphanumeric character.
            //If the input character is an alphabetic character, the program checks whether the input character is lowercase or uppercase using "nested if"

            Console.WriteLine("Enter a character");
            // char c = (char)Console.Read();
            char c = char.Parse(Console.ReadLine());
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))

                {
                    Console.WriteLine("The character is a lowercase alphabet");
                }
                else
                {
                    Console.WriteLine("The character is an uppercase alphabet");
                }
            }
            else if (Char.IsDigit(c))
            {
                Console.WriteLine("The character is a digit");
            }
            else
            {
                Console.WriteLine("The entered character isn't an alphanumeric character");
            }



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
                    Console.WriteLine(s1 + " is vowel");
                    break;
                default:
                    Console.WriteLine("The entered character is not a vowel");
                    break;
            }

            // Using switch statement to test color
            Console.WriteLine();
            Color co = (Color)(new Random()).Next(0, 10);
            switch (co)
            {
                case Color.Red:
                    Console.WriteLine("The color is red");
                    break;
                case Color.Blue:
                    Console.WriteLine("The color is blue");
                    break;
                case Color.Green:
                    Console.WriteLine("The color is green");
                    break;
                default:
                    Console.WriteLine("The color is unknown");
                    break;
            }


            //switch section
            Console.WriteLine();
            Random rnd = new Random();
            int caseSwitch = rnd.Next(1, 4);

            switch (caseSwitch)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine($"Case {caseSwitch}");
                    break;
                default:
                    Console.WriteLine($"An unexpected value({caseSwitch}). This string will never be printed because of Next(1,4)");
                    break;
            }

            //switch section
            //constant pattern to determine today's work week
            Console.WriteLine();
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("Today is weekend");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Today is the first day of the work week");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Today is the last day of the work week");
                    break;
                default:
                    Console.WriteLine("Today is the middle of the work week");
                    break;
            }

            //switch section
            //constant pattern to handle user input that simulates an automatic coffee machine
            // Because of the goto statements in cases 2 and 3, the base cost of 25 cents is added to the additional cost for
            // the medium and large sizes

            Console.WriteLine();
            Console.WriteLine("Coffee sizes: 1=small 2=medium 3=large");
            Console.Write("Please enter your selection: ");
            string str = Console.ReadLine();
            int cost = 0;

            switch (str)
            {
                case "1":
                case "small":
                    cost += 25;
                    break;
                case "2":
                case "medium":
                    cost += 25;
                    goto case "1";
                case "3":
                case "large":
                    cost += 50;
                    goto case "1";
                default:
                    Console.WriteLine("Invalid selection. Please select 1, 2, or 3.");
                    break;
            }
            if (cost != 0)
            {
                Console.WriteLine("Please insert {0} cents.", cost);
            }
            Console.WriteLine("Thank you for your business");




            //non-mutually exclusive patterns (case statement) starting from C#7.0
            Console.WriteLine();
            var values = new List<object>(); //Anonymous Type 'var' in generic collection 'List<object>'
            for (int ctr = 0; ctr <= 7; ctr++)
            {
                if (ctr == 2)
                {
                    values.Add(DiceLibrary.Roll2());
                }
                else if (ctr == 4 || ctr == 7)
                {
                    values.Add(DiceLibrary.Pass());
                }
                else
                {
                    values.Add(DiceLibrary.Roll());
                }
                Console.WriteLine($"The sum of {values.Count} die is {DiceLibrary.DiceSum(values)} ");
            }

            //Another non-mutually exclusive case statement starting from C#7.0
            //The 'case' statement and the 'when' clause
            Console.WriteLine();
            Shape sha = null;
            Shape[] shapes = { new Square(10), new Rectangle(5, 7), sha, new Square(0), new Rectangle(8, 8), new Circle(3),
                               null, new Rectangle(0,0), new Amoeba(1)};
            foreach (var shape in shapes)
            {
                ShowShapeInfo(shape);
            }


            // foreach Loop
            // Array
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/statements

            //Declaration statement
            int counter;

            //Assignment statement
            counter = 1;

            // This is an expression, not an expression statement
            // counter + 1;

            //Declaration statements with initializers are functionally equivalent to declaration statement followed by assignment statement
            int[] radii = { 15, 32, 108, 74, 9 }; //Declare and initialize an array
            const double pi = 3.14159; //Declare and initialize constant

            Console.WriteLine();

            //foreach statement block that contains multiple statements
            foreach (int radius in radii)
            {
                //Declaration statement with initializer
                double circumference = 2 * pi * radius;

                //Expression statement (method invocation). 
                //A single-line statement can span multiple text lines because line breaks are treated as white spaces which is ignored by complier
                System.Console.WriteLine("Radius of circle #{0} is {1}. Circumference = {2}", counter, radius, circumference);
                System.Console.WriteLine("Radius of circle #{0} is {1}. Circumference = {2:N2}", counter, radius, circumference);

                //Expression statement (postfix increment)
                counter++;
            } //End of foreach statement block

            // Type pattern, swtich statement: type pattern to provide information about various kinds of collection types
            Console.WriteLine();
            int[] values_one = { 2, 4, 6, 8, 10 };
            ShowCollectionInformation_one(values_one);

            var names_one = new List<string>();
            names_one.AddRange(new string[] { "Adam", "Abigail", "Bertrand", "Bridgette" });
            ShowCollectionInformation_one(names_one);

            List<int> numbers_one = null;
            ShowCollectionInformation_one(numbers_one);

            //Type pattern, switch statement: Instead of object, making a generic method using the type of collection as the type parameter
            Console.WriteLine();
            int[] values_two = { 11, 12, 13, 14, 15 };
            ShowCollectionInformation_two(values_two);

            var names_two = new List<string>();
            names_two.AddRange(new string[] { "Aaron", "Andy", "Dominick", "Emily" });
            ShowCollectionInformation_two(names_two);

            List<int> numbers_two = null;
            ShowCollectionInformation_two(numbers_two);

            //to pause this program at the end until it reads an input
            Console.ReadLine();

        } //End of Main method body

    } //End of Program class



} //End of namespace Study_ConsoleApp













