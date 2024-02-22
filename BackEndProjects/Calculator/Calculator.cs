using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.Calculator
{
    internal class Calculator
    {

        public void Run()
        {

            Console.WriteLine("Welcome to the Console Calculator!");

            while (true)
            {

                double num1, num2;
                char operation;

                Console.WriteLine("Press 1 to continue or press any other key to quit");
                var num = Console.ReadLine();
                if (num !="1") { break; }
                Console.WriteLine("Please enter the first number:");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }

                Console.WriteLine("Please enter the second number:");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }

                Console.WriteLine("Please enter the operation (+, -, *, /):");
                while (!char.TryParse(Console.ReadLine(), out operation) || !IsOperationValid(operation))
                {
                    Console.WriteLine("Invalid input. Please enter a valid operation (+, -, *, /):");
                }

                double result = Calculate(num1, num2, operation);
                Console.WriteLine($"Result: {result}");


            }

        }
        private bool IsOperationValid(char operation)
        {
            return operation == '+' || operation == '-' || operation == '*' || operation == '/';
        }
        private double Calculate(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    
                      /*  throw new Exception ("Error: Cannot divide by zero.");*/
                        try {
                           return num1 / num2;


                        }catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                    return 0;
                    /*return num1 / num2;*/
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    Environment.Exit(0);
                    return 0;
            }
        }


    }
}
