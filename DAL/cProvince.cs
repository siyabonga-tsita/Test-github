using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cProvince
    {
        public int ProvinceID { get; set; }
        public string ProvinceDesc { get; set; }

        //Insert Constructor
        public cProvince(string provinceDesc) 
        {
            this.ProvinceDesc = provinceDesc;
        }

        //Select Constructor
        public cProvince() 
        {
        
        }
    }
}
