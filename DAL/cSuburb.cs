using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cSuburb
    {
        public int SuburbID { get; set; }
        public string SuburbDesc { get; set; }
        public string PostalCode { get; set; }
        public int CityID{ get; set; }

        //Insert Constr
        public cSuburb(string suburbDesc, string code, int cityID) 
        {
            this.SuburbDesc = suburbDesc;
            this.PostalCode = code;
            this.CityID = cityID;
        }
        
        //Select Constr
        public cSuburb() 
        {
        
        }
    }
}
