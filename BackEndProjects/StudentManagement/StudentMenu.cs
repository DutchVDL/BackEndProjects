using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.StudentManagement
{
    internal class StudentMenu
    {
        public StudentManager Manager = new StudentManager(new List<Student>() { new Student() { Grade='a' , Name="aa" , RollNumber=1 } });
        public void Run()
        {
            Console.WriteLine("Welcome to Book Management System");
            while (true)
            {
                
                Console.WriteLine("Instruction:");
                Console.WriteLine(" press 1 to see all students");
                Console.WriteLine(" press 2 to find student with RollNumber");
                Console.WriteLine(" press 3 to edit student's grade");
                Console.WriteLine(" press 4 to add a new student");
                Console.WriteLine(" press any other number to exit the program");

                int number;
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Invalid Number! Please follow the given Instructions");
                };

                if (number == 1)
                {
                    Manager.showStudents();
                }
                else if (number == 2)
                {
                    Console.WriteLine("Enter Student's RollNumber");
                    int rollNumber;
                    while (!int.TryParse(Console.ReadLine(), out rollNumber))
                    {
                        Console.WriteLine("Invalid Number! Please follow the given Instructions");
                    };
                    var student= Manager.findByRollNumber(rollNumber);
                    Console.WriteLine(student);
                }
                else if (number == 3)
                {
                    Console.WriteLine("Enter Student's RollNumber");
                    int rollNumber;
                    while (!int.TryParse(Console.ReadLine(), out rollNumber))
                    {
                        Console.WriteLine("Invalid Number! Please follow the given Instructions");
                    };
                    var student=Manager.findByRollNumber(rollNumber);
                    if (student != null) { return ; }
                    Console.WriteLine($"The Grade of {student.Name} is {student.Grade} ");
                    Console.WriteLine("Enter Student's new grade");

                    char newGrade;
                    while (!char.TryParse(Console.ReadLine(), out newGrade))
                    {
                        Console.WriteLine("Invalid Grade! Please follow the given Instructions");
                    };
                    Manager.editGrade(rollNumber, newGrade);
                }
                else if (number == 4)
                {
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
                    Student newStudent = new Student() { Grade = newGrade , Name = name , RollNumber = rollNumber};
                    Manager.AddStudent(newStudent);
                }
            }
        }

    }
}
