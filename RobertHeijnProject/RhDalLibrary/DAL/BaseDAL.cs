using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RhDalLibrary.DAL
{
    public abstract class BaseDAL
    {
        protected string connectionstring;
        protected SqlConnection sqlConnection;
        protected BaseDAL()
        {
            this.connectionstring = "Data Source=mssqlstud.fhict.local;User ID=dbi491606_robheijn;Password=1234; Connection Timeout = 1";
            this.sqlConnection = new SqlConnection(this.connectionstring);
        }
        protected SqlCommand CreateCommand(string commandtext, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(commandtext, sqlConnection);
            foreach (SqlParameter parameter in parameters)
            {
                cmd.Parameters.AddWithValue(parameter.ParameterName, parameter.Value);
            }
            return cmd;
        }
        protected SqlCommand CreateCommand(string commandtext)
        {
            SqlCommand cmd = new SqlCommand(commandtext, sqlConnection);
            return cmd;
        }
        protected bool OpenConnection()
        {
            try
            {
                sqlConnection.Open();
                return true;
            }
            catch(SqlException ex) { return false; }
        }
        protected void CloseConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch(SqlException ex) { throw new Exception("Database connection could not be closed."); }
        }
    }
}
