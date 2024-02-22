using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndProjects
{
    public class ATM
    {
        public User user { get; set; }
        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public ATM(User user)
        {
            this.user = user;
            

          
        }

        public void checkBalance(string username)
        {
            string fileName = $"{username}.txt";
            string filePath = Path.Combine(desktopPath, fileName);
            User newUser;

            using (StreamReader sr = new StreamReader(filePath))
            {
                
            }
           
        }
    }
}

