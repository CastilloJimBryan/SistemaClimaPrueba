using BEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;


namespace DAL
{
    public class DAO
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBA"].ConnectionString);
        public DataSet Read(string sql)
        {
            try
            {
                SqlDataAdapter sqlData=new SqlDataAdapter(sql,con);
                DataSet set = new DataSet();
                sqlData.Fill(set);
                return set;
            }
            catch(Exception ex) { throw ex; }
            finally { if(con.State!= ConnectionState.Closed) con.Close();}
        }
        public int Write(string sql)
        {
            try
            {
                ///
                return 0;
            }
            catch (Exception ex) { throw ex; }
            finally { if (con.State != ConnectionState.Closed) con.Close(); }
        }
        public int UltimoId(string tabla)
        {
            try
            {
                ////
                return 0; 
            }
            catch (Exception ex) { throw ex; }
            finally { if (con.State != ConnectionState.Closed) con.Close(); }
        }
    }
}
