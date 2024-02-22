using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects.StudentManagement
{
    internal class Student
    {
        public string Name { get; set; }
        
        public int RollNumber { get; set; }
        public char Grade { get; set; }


        public override string ToString()
        {
            return $"Name : {Name} , RollNumber : {RollNumber} , Grade : {Grade}";
        }

    }
}
