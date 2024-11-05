using System;
using System.Numerics;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {


            string op = "";

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            calculator(num1, num2, op);
            
        }

        static void calculator(double num1, double num2, string op)
        {

            while (op != "+" && op != "-" && op != "*" && op != "/")
            {
                Console.Write("Choose if +, - , *, or /: ");
                op = Console.ReadLine();
                Console.WriteLine();
            }

            Console.Write("The answer is: ");
            switch (op)
            {
                case "+":
                    Console.WriteLine(num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(num1 / num2);
                    break;
            }
        }
    }
}
