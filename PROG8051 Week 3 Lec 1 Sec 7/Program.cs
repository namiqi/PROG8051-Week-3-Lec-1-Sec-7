using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {

            // Rock Paper Scissor

            Console.WriteLine("P1 choice: ");

            string p1 = Console.ReadLine();

            Console.WriteLine("P2 choice: ");

            string p2 = Console.ReadLine();

            if (p1 == p2) {
                Console.WriteLine("draw");
            }

            else if (p1 == "R" && p2 == "P")
            {
                Console.WriteLine("P wins");
            }

            else if (p1 == "R" && p2 == "S")
            {
                Console.WriteLine("S wins");
            }

            // Switch Case
            int month = 1;

            switch (month)
            {
                case 1:
                    // code block
                    Console.WriteLine("January");
                    break;
                case 2:
                    // code block
                    Console.WriteLine("February");
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    // code block
                    break;
            }


            // Exercise

            Console.WriteLine("Please enter 1st num: ");

            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter 2nd num: ");

            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter operation: ");

            string op = Console.ReadLine();

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            }

            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }

            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            }

            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }

            else
            {
                Console.WriteLine("");
            }

            switch (op) {

                case "+":
                    // code block
                    Console.WriteLine(num1 +num2);
                    break;
                case "-":
                    // code block
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    // code block
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    // code block
                    Console.WriteLine(num1 / num2);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    // code block
                    break;
            }



            

            // Conditional statements

            // If/else

            // list of keywords: if/else/else if

            /*if (condition) 
            { 
                // true case - do some action
            }*/

            int a = 5;
            int b = 5;
          /*  if (a != b)
            {
                Console.WriteLine("a is equal to be");
            }
            else
            {
                Console.WriteLine("a is not equal to be");
            }*/

            // short hand if...else

            // variable = (condition) ? expressionTrue :  expressionFalse;

            string output = (a != b) ? "a is equal to be" : "a is not equal to be";

            Console.WriteLine(output);

            if (5 > 3 && 5 > 2) { 
                Console.WriteLine("This is true");
            }

            else
            {
                Console.WriteLine("This is false");
            }

            // Logical operations && and ||

            Console.WriteLine(5 > 3 && 5 > 2);

          // Else if

          

          // Rock/Paper/ Scissors

          // Assignment 1
        }
    }
}