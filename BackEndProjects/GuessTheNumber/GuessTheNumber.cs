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

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Game - 'Guess The Number'. To exit the program press 'q' or press anything else to continue ");

                var exit = Console.ReadLine();
                if (exit == "q") break;



                guess(getRandomNumber());
            }
        }



        public int getRandomNumber()
        {
            int num1;
            int num2;
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

            Random random = new Random();
            int randomNumber;
            if (num1 > num2) {
                randomNumber = random.Next(num2, num1);


            }
            else
            {
                randomNumber = random.Next(num1, num2);
            }
             

            return randomNumber;
        }



        public void guess(int targetNum)
        {
            int count = 1;
            int num;
            Console.WriteLine("Guess the number");
            while (true)
            {


                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number:");
                }

                if (num == targetNum)
                {
                    Console.WriteLine($"you have guessed the number {targetNum} in {count} tries");
                    break;
                }
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
