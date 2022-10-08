using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cAgency
    {
        public int AgencyID { get; set; }
        public string AgencyName { get; set; }
        public int SuburbID { get; set; }

        //Insert Constructor
        public cAgency(string agencyName, int suburb) 
        {
            this.AgencyName = agencyName;
            this.SuburbID = suburb;
        }
        //Select Constructor
        public cAgency()         
        {
        
        }

        //Delete Contructor
        public cAgency(int agencyID)         
        {
            this.AgencyID = agencyID;
        }
    }
}
