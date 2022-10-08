using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cAdmin
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }

       //insert constructor
        public cAdmin(string name, string surname, string email, string password) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
        }
        //select constructor
        public cAdmin(string email, string password) 
        {
            this.Email = email;
            this.Password = password;
        }

        //Select
        public cAdmin() 
        {
        
        }
    }
}
