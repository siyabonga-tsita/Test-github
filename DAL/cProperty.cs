using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class cProperty
    {
        public int PropertyID { get; set; }
        public string PropertyDesc { get; set; }
        public double Price { get; set; }
        public string PropertyImage { get; set; }
        public int PropertyTypeID { get; set; }
        public string Status { get; set; }
        public int SuburbID { get; set; }


        //Insert Constr
        public cProperty(string propDesc, double price, string image, int propTypeID, string status, int suburbID) 
        {
            this.PropertyDesc = propDesc;
            this.Price = price;
            this.PropertyImage = image;
            this.PropertyTypeID = propTypeID;
            this.Status = status;
            this.SuburbID = suburbID;
        }
        ////Select Constr
        //public cProperty()
        //{

        //}
        ////Update Constr
        //public cProperty()
        //{

        //}
        ////Delete Constr
        //public cProperty()
        //{

        //}
    }
}
