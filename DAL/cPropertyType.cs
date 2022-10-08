using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cPropertyType
    {
        public int PropTypeID { get; set; }
        public string PropTypeDesc { get; set; }

        //Insert Constructor
        public cPropertyType(string desc) 
        {
            this.PropTypeDesc = desc;
        }

        //select Constructor
        public cPropertyType() 
        {
        
        }
    }
}
