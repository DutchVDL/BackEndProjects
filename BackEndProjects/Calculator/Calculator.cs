using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.Calculator
{
    internal class Calculator
    {
        // Method to start the Calculator application
        public void Run()
        {
            Console.WriteLine("Welcome to the Calculator!");

            while (true)
            {
                // Variables to store user input
                double num1, num2;
                char operation;

                // Prompt user to continue or quit
                Console.WriteLine("Press 1 to continue or press any other key to quit");
                var num = Console.ReadLine();
                if (num != "1") { break; }

                // Prompt user to enter the first number
                Console.WriteLine("Please enter the first number:");
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }

                // Prompt user to enter the second number
                Console.WriteLine("Please enter the second number:");
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }

                // Prompt user to enter the operation
                Console.WriteLine("Please enter the operation (+, -, *, /):");
                while (!char.TryParse(Console.ReadLine(), out operation) || !IsOperationValid(operation))
                {
                    Console.WriteLine("Invalid input. Please enter a valid operation (+, -, *, /):");
                }

                // Calculate the result and display it
                double result = Calculate(num1, num2, operation);
                Console.WriteLine($"Result: {result}");
            }
        }

        // Method to check if the operation is valid
        private bool IsOperationValid(char operation)
        {
            return operation == '+' || operation == '-' || operation == '*' || operation == '/';
        }

        // Method to perform the calculation
        private double Calculate(double num1, double num2, char operation)
        {
            // Perform the calculation based on the operation
            switch (operation)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    // Check for division by zero
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        // Return NaN (Not a Number) to represent an invalid result
                        return double.NaN;
                    }
                    // Perform the division
                    return num1 / num2;
                default:
                    Console.WriteLine("Error: Invalid operation.");
                    // Return NaN (Not a Number) to represent an invalid result
                    return double.NaN;
            }
        }
    }
}
