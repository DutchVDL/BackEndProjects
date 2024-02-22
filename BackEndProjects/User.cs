using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BackEndProjects
{
    public class User
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int balance { get; set; }

        public string Username { get; set; }
      

        public User (string name, string lastname, string email, string password, int balance , string username)
        {
            Name = name;
            Lastname = lastname;
            Email = email;
            Password = password;
            this.balance = balance;
            Username = username;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string fileName = $"{Username}.xml";
            string filePath = Path.Combine(desktopPath, fileName);

           
                using (XmlWriter writer = XmlWriter.Create(filePath))
                {
               
               
                }

                Console.WriteLine("User data has been written to the file.");
            
          


        }

        public override string ToString()
        {
            return $"Name - {Name} , Lastname - {Lastname} , Email - {Email} , Password - {Password} , Balance - {balance}";
        }
    }
}
