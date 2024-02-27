using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BackEndProjects.ATM
{
    public class ATM
    {

        private string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        public void Run()
        {
            Console.WriteLine("Enter the Username");

            string username = Console.ReadLine();



            string fileName = $"{username}.txt";
            string filePath = Path.Combine(desktopPath, fileName);



            if (!File.Exists(filePath))
            {
                try
                {
                    Console.WriteLine("The User was not registered before");
                    File.Create(filePath).Close();
                    Console.WriteLine("New account created successfully. Please enter your username to sign in next time.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error creating translation file '{username}.txt': {ex.Message}");
                }
            }



            while (true)
            {
                int selectedOption;
                Console.WriteLine("Select Options: 1 - Check the Balance; 2 - Withdraw Money; 3 - Transfer Money; 4 - Exit the System");
                while (!int.TryParse(Console.ReadLine(), out selectedOption) || selectedOption > 4)
                {
                    Console.WriteLine("Invalid Input! Please enter the correct Number");
                }

                if (selectedOption == 3)
                {
                    Console.WriteLine("Transfer Money: ")
                    double money;
                    while (!double.TryParse(Console.ReadLine(), out money))
                    {
                        Console.WriteLine("Invalit Input, Please enter the correct Format");
                    }

                    double balance = getBalance(filePath);
                    File.AppendAllText(filePath, $"{money} - was transferred on {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\n");

                    File.AppendAllText(filePath, $"new balance {money + balance} \n");
                    Console.WriteLine(getBalance(filePath));

                }
                else if (selectedOption == 1)
                {
                    Console.WriteLine("Your Balance:");
                    Console.WriteLine(getBalance(filePath));
                }
                else if (selectedOption == 2)
                {
                    double withrdawAmount;
                    Console.WriteLine("Please enter the amount you would like to withdraw ");
                    while (!double.TryParse(Console.ReadLine(), out withrdawAmount) || withrdawAmount > getBalance(filePath))
                    {
                        Console.WriteLine("Invalid Request! Either wrong Format or not enough Funds on the Balance");
                    }

                    double newBalance = moneyWithdrawal(getBalance(filePath), withrdawAmount);

                    File.AppendAllText(filePath, $"{withrdawAmount} - was withdrawn on {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\n");

                    File.AppendAllText(filePath, $"new balance {newBalance} \n");
                    Console.WriteLine($"{withrdawAmount} was withdrawn successfully");
                }
                else if (selectedOption == 4)
                {
                    break;

                }
            }





        }

        public double getBalance(string filePath)
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0) return 0.0;

            string lastLine = lines[lines.Length - 1];



            string[] parts = lastLine.Split(' ');

            // Find the part containing the new balance
            foreach (string part in parts)
            {
                if (part.Equals("balance"))
                {
                    // Get the index of the next part which contains the balance value
                    int index = Array.IndexOf(parts, part) + 1;

                    // Extract the balance value and parse it as double
                    if (index < parts.Length)
                    {
                        if (double.TryParse(parts[index], out double newBalance))
                        {

                            return newBalance;
                        }

                    }


                    break;
                }
            }






            return 0.0;
        }


        public double moneyWithdrawal(double balance, double withdrawMoney)
        {
            if (balance >= withdrawMoney)
            {
                balance = balance - withdrawMoney;

            }
            return balance;

        }
    }
}

