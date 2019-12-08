using System.Collections.Generic;
using System.Data.SqlClient;

namespace BookLeasing.DAL
{
    public class Helper
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Helper()
        {
            conn = new SqlConnection(Properties.Settings.Default.BookLeasing);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        public void AddParametersToCommand(List<SqlParameter> paramList)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddRange(paramList.ToArray());
        }

        public int MyExecuteQuery(string query)
        {
            cmd.CommandText = query;
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public T MyExecuteScalar<T>(string query)
        {
            T returnValue;
            cmd.CommandText = query;
            conn.Open();
            returnValue = (T)cmd.ExecuteScalar();
            conn.Close();

            return returnValue;
        }

        public SqlDataReader MyExecuteReader(string query)
        {
            cmd.CommandText = query;
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            return reader;
        }
    }
}