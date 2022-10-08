using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cCity
    {
        public int CityID { get; set; }
        public string CityDescription { get; set; }
        public int ProvinceID { get; set; }

        //Insert Constructor
        public cCity(string cityDesc, int provinceID) 
        {
            this.CityDescription = cityDesc;
            this.ProvinceID = provinceID;
        }

        //Select Constructor
        public cCity() 
        {
        
        }
    }
}
