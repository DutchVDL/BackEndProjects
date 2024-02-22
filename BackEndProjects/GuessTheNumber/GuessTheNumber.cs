using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BackEndProjects.GuessTheNumber
{
    internal class GuessTheNumber
    {
        // Method to start the Guess The Number game
        public void Run()
        {
            // Main loop for the game
            while (true)
            {
                // Prompt user to start or exit the game
                Console.WriteLine("Welcome to the Game - 'Guess The Number'. To exit the program press 'q' or press anything else to continue ");
                var exit = Console.ReadLine();
                if (exit == "q") break;

                // Start the game
                guess(getRandomNumber());
            }
        }

        // Method to generate a random number within a user-defined range
        public int getRandomNumber()
        {
            int num1;
            int num2;
            // Prompt user to enter the range of numbers
            Console.WriteLine("Enter the first Number");
            while (!int.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }
            Console.WriteLine("Enter the second Number");
            while (!int.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }

            // Generate a random number within the specified range
            Random random = new Random();
            int randomNumber;
            if (num1 > num2)
            {
                randomNumber = random.Next(num2, num1);
            }
            else
            {
                randomNumber = random.Next(num1, num2);
            }
            return randomNumber;
        }

        // Method to play the Guess The Number game
        public void guess(int targetNum)
        {
            int count = 1;
            int num;
            Console.WriteLine("Guess the number");
            while (true)
            {
                // Prompt user to guess the number
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }

                // Check if the guessed number matches the target number
                if (num == targetNum)
                {
                    Console.WriteLine($"You have guessed the number {targetNum} in {count} tries");
                    break;
                }
                // Provide hints based on the guessed number
                else if (num < targetNum)
                {
                    Console.WriteLine("Target number is higher");
                    count++;
                }
                else
                {
                    Console.WriteLine("Target number is lower");
                    count++;
                }
            }
        }
    }



}
