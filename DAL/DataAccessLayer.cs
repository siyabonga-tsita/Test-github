using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added directives
using System.Data;
using System.Data.SqlClient;
using System.IO;


namespace DAL
{
    public class DataAccessLayer
    {
        //Class instantiation

        static string sConn = "Data Source = localhost; Initial Catalog = Project-Prototype; Integrated Security = true;";

        SqlConnection dbConn = new SqlConnection(sConn);
        SqlCommand dbComm;
        SqlDataAdapter dbAdapter;
        DataTable dt;

        public int InsertAdmin(cAdmin admin) 
        {
            try 
            {
                if (dbConn.State != ConnectionState.Open) 
                {
                    dbConn.Open();
                }
            } catch { }

            dbComm = new SqlCommand("sp_InsertAdmin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name",admin.Name);
            dbComm.Parameters.AddWithValue("@Surname",admin.Surname);
            dbComm.Parameters.AddWithValue("@Email",admin.Email);
            dbComm.Parameters.AddWithValue("@Password",admin.Password);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable SelectAdmin(cAdmin admin) 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_SelectAdminLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email",admin.Email);
            dbComm.Parameters.AddWithValue("@Password",admin.Password);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public DataTable SelectAdminFullName()
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            dbComm = new SqlCommand("sp_SelectAdminLogin", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;           

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="Property type"></param>
        /// <returns></returns>
        public int InsertPropType(cPropertyType type) 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            //string sql = "sp_InsertPropertyType";

            dbComm = new SqlCommand("sp_InsertPropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyTypeDescription",type.PropTypeDesc);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable SelectPropType() 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            //string sql = "sp_SelectPropertyType";

            dbComm = new SqlCommand("sp_SelectPropertyType", dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Province"></param>
        /// <returns></returns>
        public int InsertProvince(cProvince province) 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_InsertProvince";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Description",province.ProvinceDesc);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable SelectProvince() 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_SelectProvince";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="city"></param>
        /// <returns></returns>
        public int InsertCity(cCity city) 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_InsertCity";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@CityDescription", city.CityDescription);
            dbComm.Parameters.AddWithValue("@ProvinceID",city.ProvinceID);

            int x = dbComm.ExecuteNonQuery(); 

            dbConn.Close();

            return x;
        }

        public DataTable SelectCity() 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_SelectCity";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="suburb"></param>
        /// <returns></returns>
        public int InsertSuburb(cSuburb suburb)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_InsertSuburb";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@SuburbDescription",suburb.SuburbDesc);
            dbComm.Parameters.AddWithValue("@PostalCode", suburb.PostalCode);
            dbComm.Parameters.AddWithValue("@CityID", suburb.CityID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable SelectSuburb()
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_SelectSuburb";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <returns></returns>
        public int InsertAgent(cAgent agent)         
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }
            
            string sql = "sp_InsertAgent";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Name",agent.Name);
            dbComm.Parameters.AddWithValue("@Surname", agent.Surname);
            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Password", agent.Password);
            dbComm.Parameters.AddWithValue("@Phone", agent.Phone);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);
            dbComm.Parameters.AddWithValue("@AgencyID", agent.AgencyID);            

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;

        }

        public DataTable SelectAgent() 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_SelectAgent";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public int UpdateAgent(cAgent agent) 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_UpdateAgent";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID",agent.AgentID);
            dbComm.Parameters.AddWithValue("@Phone",agent.Phone);
            dbComm.Parameters.AddWithValue("@Status ",agent.Status);
            dbComm.Parameters.AddWithValue("@Email",agent.Email);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public int DeleteHard_Agent(cAgent agent ) 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_DeleteAgent";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public int DeleteSoft_Agent(cAgent agent)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_SoftDel_Agent";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgentID", agent.AgentID);
            dbComm.Parameters.AddWithValue("@Status", agent.Status);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }
        
        public DataTable DisplayAll_Agent() 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_DisplayAll_Agent";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;

        }
       


        /// <summary>
        /// 
        /// </summary>
        /// <param name="agency"></param>
        /// <returns></returns>
        public int InsertAgency(cAgency agency) 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_InsertAgency";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            
            dbComm.Parameters.AddWithValue("@AgencyName", agency.AgencyName);
            dbComm.Parameters.AddWithValue("@SuburbID", agency.SuburbID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable SelectAgency() 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_SelectAgency";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        public int DeleteAgency(cAgency agency) 
        {

            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_DeleteAgency";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@AgencyID", agency.AgencyID);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propAgent"></param>
        /// <returns></returns>
        public int Insert_PropAgent(cPropertyAgent propAgent) 
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_InsertPropertyAgent";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyID",propAgent.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID",propAgent.AgentID);
            dbComm.Parameters.AddWithValue("@Date",propAgent.Date);          

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }


        public int Update_PropAgent(cPropertyAgent propAgent)
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_UpdatePropertyAgent";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@PropertyAgentID", propAgent.PropAgentID);
            dbComm.Parameters.AddWithValue("@PropertyID", propAgent.PropertyID);
            dbComm.Parameters.AddWithValue("@AgentID", propAgent.AgentID);
            dbComm.Parameters.AddWithValue("@Date", propAgent.Date);

            int x = dbComm.ExecuteNonQuery();

            dbConn.Close();

            return x;
        }

        public DataTable Select_PropAgent()
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_SelectPropertyAgent";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }


        /// <summary>
        /// /
        /// </summary>
        /// <param name="property"></param>
        /// <returns></returns>
        /// 

        //public int Insert_Property(cProperty prop) 
        //{

        ////    try
        ////    {
        ////        if (dbConn.State != ConnectionState.Open)
        //        {
        //            dbConn.Open();
        //        }
        //    }
        //    catch { }

        //    string sql = "sp_InsertProperty";

        //    dbComm = new SqlCommand(sql, dbConn);
        //    dbComm.CommandType = CommandType.StoredProcedure;

        //    dbComm.Parameters.AddWithValue("@Description",prop.PropertyDesc );
        //    dbComm.Parameters.AddWithValue("@Price",prop.Price);

        //    MemoryStream memoryStream = new MemoryStream();
        //    prop.PropertyImage.Image.Save(memoryStream, prop.PropertyImage.Image.RawFormat);

        //    dbComm.Parameters.AddWithValue("@Image",  );
        //    dbComm.Parameters.AddWithValue("@PropertyTypeID", prop.PropertyTypeID);
        //    dbComm.Parameters.AddWithValue("@Status", prop.Status);
        //    dbComm.Parameters.AddWithValue("@SuburbID", prop.SuburbID);           

        //    int x = dbComm.ExecuteNonQuery();

        //    dbConn.Close();

        //    return x;

        //}

        public DataTable SelectProperty()
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_SelectProperty";

            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();

            dt.Clear();
            dbAdapter.Fill(dt);

            dbConn.Close();

            return dt;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="agent"></param>
        /// <returns></returns>
        public DataTable SelectAgent_Login(cAgent agent)
       
        {
            try
            {
                if (dbConn.State != ConnectionState.Open)
                {
                    dbConn.Open();
                }
            }
            catch { }

            string sql = "sp_SelectAgent_Login";


            dbComm = new SqlCommand(sql, dbConn);
            dbComm.CommandType = CommandType.StoredProcedure;

            dbComm.Parameters.AddWithValue("@Email", agent.Email);
            dbComm.Parameters.AddWithValue("@Password", agent.Password);

            dbAdapter = new SqlDataAdapter(dbComm);
            dt = new DataTable();
            dbAdapter.Fill(dt);
            dbConn.Close();

            return dt;
        }
    }
}

