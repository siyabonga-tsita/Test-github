using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cPropertyAgent
    {
        public int PropAgentID { get; set; }
        public int PropertyID { get; set; }
        public int AgentID { get; set; }
        public string Date { get; set; }


        //Insert Constructor
        public cPropertyAgent(int propertyID,int agentID,string date) 
        {
            this.PropAgentID = propertyID;
            this.AgentID = agentID;
            this.Date = date;
        }
        //Select Constructor
        public cPropertyAgent()
        {

        }

        //Update Constructor
        public cPropertyAgent( int propAgentID,int propertyID, int agentID, string date)
        {
            this.PropAgentID = propAgentID;
            this.AgentID = agentID;
            this.Date = date;
            this.PropertyID = propertyID;
        }

    }
}
