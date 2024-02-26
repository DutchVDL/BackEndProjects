using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.StudentManagement
{
    internal class StudentMenu
    {

        private StudentManager Manager = new StudentManager();

        // Method to start the student menu interface
        public void Run()
        {

            Console.WriteLine("Welcome to Book Management System");

            // Main loop for user interaction
            while (true)
            {
                // Display instructions
                Console.WriteLine("Instruction:");
                Console.WriteLine("Press 1 to see all students");
                Console.WriteLine("Press 2 to find student with RollNumber");
                Console.WriteLine("Press 3 to edit student's grade");
                Console.WriteLine("Press 4 to add a new student");
                Console.WriteLine("Press any other number to exit the program");

                int number;
                // Input validation loop
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid Number! Please follow the given Instructions");
                };


                if (number == 1)
                {
                    // Display all students
                    Manager.showStudents();
                }
                else if (number == 2)
                {
                    // Find a student by roll number
                    Console.WriteLine("Enter Student's RollNumber");
                    int rollNumber;
                    while (!int.TryParse(Console.ReadLine(), out rollNumber))
                    {
                        Console.WriteLine("Invalid Number! Please follow the given Instructions");
                    };
                    var student = Manager.findByRollNumber(rollNumber);
                    Console.WriteLine(student);
                }
                else if (number == 3)
                {
                    // Edit student's grade
                    Console.WriteLine("Enter Student's RollNumber");
                    int rollNumber;
                    while (!int.TryParse(Console.ReadLine(), out rollNumber))
                    {
                        Console.WriteLine("Invalid Number! Please follow the given Instructions");
                    };
                    var student = Manager.findByRollNumber(rollNumber);
                    if (student == null) { return; }
                    Console.WriteLine($"The Grade of {student.Name} is {student.Grade} ");
                    Console.WriteLine("Enter Student's new grade");

                    char newGrade;
                    while (!char.TryParse(Console.ReadLine(), out newGrade) || isCharValid(newGrade))
                    {
                        Console.WriteLine("Invalid Grade! Please follow the given Instructions");
                    };
                    Manager.editGrade(rollNumber, newGrade);
                }
                else if (number == 4)
                {
                    // Add a new student
                    Console.WriteLine("Enter Student's Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Student's RollNumber");
                    int rollNumber;
                    while (!int.TryParse(Console.ReadLine(), out rollNumber))
                    {
                        Console.WriteLine("Invalid Number! Please follow the given Instructions");
                    };


                    Console.WriteLine("Enter Student's  grade");

                    char newGrade;
                    while (!char.TryParse(Console.ReadLine(), out newGrade))
                    {
                        Console.WriteLine("Invalid Grade! Please follow the given Instructions");
                    };
                    Student newStudent = new Student() { Grade = newGrade, Name = name, RollNumber = rollNumber };
                    Manager.AddStudent(newStudent);
                }
                else
                {
                    // Exit the program
                    break;
                }
            }
        }

        public bool isCharValid(char c)
        {
            return c == 'A' || c == 'B' || c == 'C' || c == 'D' || c == 'E' || c == 'F';
        }
    }
}
