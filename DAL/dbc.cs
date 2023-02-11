using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BAL;
namespace DAL
{
    public class dbc
    {
 
        public void IUD(string SPNAME, SqlParameter[] Sqlpara)
        {
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["constring"].ToString());
            conn.Open();
            string query = SPNAME;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < Sqlpara.Length; i++)
            {
                cmd.Parameters.Add(Sqlpara[i]);
            }
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public DataSet GetData(string SPNAME, SqlParameter[] Sqlpara)
        {
          
            DataSet ds = new DataSet();
            SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["constring"].ToString());
            string query = SPNAME;
            SqlCommand cmd = new SqlCommand(query, conn);
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            for (int i = 0; i < Sqlpara.Length; i++)
            {
                cmd.Parameters.Add(Sqlpara[i]);
            }
            cmd.CommandType = CommandType.StoredProcedure;
              
                da.Fill(ds);
            
            return ds;

        }
        

    }
}

