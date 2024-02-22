using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.StudentManagement
{
    internal class StudentManager
    {
        public static  List<Student> Students {  get; set; }

        public StudentManager()
        {
            
        }
        public StudentManager(List<Student> students)
        {
            Students = students;
        }

        public void AddStudent (Student student)
        {
            Students.Add (student);
            Console.WriteLine("Student has been added");
        }

        public void showStudents ()
        {
            if (Students == null ) {

                Console.WriteLine("The list is empty");
            }
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public Student findByRollNumber(int number )
        {
            foreach(var student in Students)
            {
                if(student.RollNumber == number) {  return  student;  }
                
            }

            return null;
        }

        public void editGrade (int number , char grade)
        {
            Student student = findByRollNumber(number);
            if (student != null)
            {
                student.Grade = grade;
                Console.WriteLine("Edit was Successfull!");
            }
            else { Console.WriteLine("Student was not Found!"); }
        }
    }
}
