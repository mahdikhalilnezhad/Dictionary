using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Dictionary
{
    internal class dictionary
    {
        public dictionary(string connStr)
        {
            conn.ConnectionString = connStr;
        }

        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        public DataTable ReturnRecordes(string wordSearch)
        {
            DataTable ret = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            SqlCommand sqlCommand = new SqlCommand();

            string sqlQueary = "select * from Word where English like '" + wordSearch + "%'";
            
            sqlCommand.CommandText = sqlQueary;
            sqlCommand.Connection = conn;

            dataAdapter.SelectCommand = sqlCommand;

            dataAdapter.Fill(ret);
            return ret;
        }




    }
}
