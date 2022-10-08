using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//directive 
using DAL;
using System.Data;

namespace BLL
{

    public class BusinessLogicLayer
    {
        DataAccessLayer dal = new DataAccessLayer();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="admin"></param>
        /// <returns></returns>
        public int InsertAdmin(cAdmin admin)
        {
            int x = dal.InsertAdmin(admin);
            return x;
        }

        public DataTable SelectAdmin(cAdmin admin)
        {
            return dal.SelectAdmin(admin);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Property type"></param>
        /// <returns></returns>
        public int InsertPropType(cPropertyType type)
        {
            return dal.InsertPropType(type);
        }

        public DataTable SelectPropType()
        {
            return dal.SelectPropType();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="province"></param>
        /// <returns></returns>
        public int InsertProvince(cProvince province)
        {
            return dal.InsertProvince(province);
        }

        public DataTable SelectProvince()
        {
            return dal.SelectProvince();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public int InsertCity(cCity city)
        {
            return dal.InsertCity(city);
        }
        public DataTable SelectCity()
        {
            return dal.SelectCity();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="suburb"></param>
        /// <returns></returns>
        public int InsertSuburb(cSuburb suburb)
        {
            return dal.InsertSuburb(suburb);
        }
        public DataTable SelectSuburb()
        {
            return dal.SelectSuburb();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <returns></returns>
        public int InsertAgent(cAgent agent)
        {
            return dal.InsertAgent(agent);
        }
        public DataTable SelectAgent()
        {
            return dal.SelectAgent();
        }
        public DataTable DisplayAll_Agent()
        {
            return dal.DisplayAll_Agent();
        }
        public int UpdateAgent(cAgent agent)
        {
            return dal.UpdateAgent(agent);
        }
        public int DeleteSoft_Agent(cAgent agent)
        {
            return dal.DeleteSoft_Agent(agent);
        }
        public int DeleteHard_Agent(cAgent agent)
        {
            return dal.DeleteHard_Agent(agent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agency"></param>
        /// <returns></returns>
        public int InsertAgency(cAgency agency)
        {
            return dal.InsertAgency(agency);
        }
        public DataTable SelectAgency()
        {
            return dal.SelectAgency();
        }
        public int DeleteAgency(cAgency agency)
        {
            return dal.DeleteAgency(agency);
        }

        public int Insert_PropAgent(cPropertyAgent propAgent)
        {
            return dal.Insert_PropAgent(propAgent);
        }

        public int Update_PropAgent(cPropertyAgent propAgent)
        {
            return dal.Update_PropAgent(propAgent);   
        }

        public DataTable Select_PropAgent()
        {
            return dal.Select_PropAgent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Property"></param>
        /// <returns></returns>
        public DataTable SelectProperty() 
        {
            return dal.SelectProperty();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <returns></returns>
        public DataTable SelectAgent_Login(cAgent agent)
        {
            return dal.SelectAgent_Login(agent);
        }
    }
}






 