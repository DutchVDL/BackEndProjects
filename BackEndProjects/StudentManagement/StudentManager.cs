using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.StudentManagement
{
    internal class StudentManager
    {
        // initialize the data
        private List<Student> Students = new List<Student>
    {
        new Student { Name = "Alice", RollNumber = 101, Grade = 'A' },
        new Student { Name = "Bob", RollNumber = 102, Grade = 'B' },
        new Student { Name = "Charlie", RollNumber = 103, Grade = 'C' },
        new Student { Name = "David", RollNumber = 104, Grade = 'B' },
        new Student { Name = "Emma", RollNumber = 105, Grade = 'A' },
        new Student { Name = "Frank", RollNumber = 106, Grade = 'B' },
        new Student { Name = "Grace", RollNumber = 107, Grade = 'C' },
        new Student { Name = "Henry", RollNumber = 108, Grade = 'A' },
        new Student { Name = "Ivy", RollNumber = 109, Grade = 'B' },
        new Student { Name = "Jack", RollNumber = 110, Grade = 'C' }
    };


        public StudentManager()
        {

        }

        // Method to add a student to the Students list
        public void AddStudent(Student student)
        {
            Students.Add(student);
            Console.WriteLine("Student has been added");
        }

        // Method to display all students in the Students list
        public void showStudents()
        {
            if (Students == null)
            {
                Console.WriteLine("The list is empty");
            }
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }

        // Method to find a student by roll number in the Students list
        public Student findByRollNumber(int number)
        {
            foreach (var student in Students)
            {
                if (student.RollNumber == number)
                {
                    return student;
                }

            }

            return null;
        }

        // Method to edit the grade of a student by roll number
        public void editGrade(int number, char grade)
        {
            Student student = findByRollNumber(number);
            if (student != null)
            {
                student.Grade = grade;
                Console.WriteLine("Edit was Successful!");
            }
            else { Console.WriteLine("Student was not Found!"); }
        }
    }
}
