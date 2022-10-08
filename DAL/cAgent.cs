using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cAgent
    {
        public int AgentID { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        public int AgencyID { get; set; }


        //Insert Constructor
        public cAgent(string name ,string surname ,string email ,string password ,string phone , string status ,int agencyID) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Email = email;
            this.Password = password;
            this.Phone = phone;
            this.Status = status;
            this.AgencyID = agencyID;

        }

        //Select Constructor
        public cAgent() 
        {
        
        }

        public cAgent(string email, string password)
        {
            this.Email = email;
            this.Password = password;
        }

        //Update Constr
        public cAgent(int agentID, string email, string phone, string status) 
        {
            this.AgentID = agentID;
            this.Email = email;
            this.Phone = phone;
            this.Status = status;
        }

        //Hard Del Construtor
        public cAgent(int agentID)
        {
            this.AgentID = agentID;
        }

        //Soft Del Constructor

        public cAgent(int agentID, string status)
        {
            this.AgentID = agentID;
            this.Status = status;
        }
    }
}
