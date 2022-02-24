using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnventureWorks2014Sample.DataAccess
{
    public class DataAccess : IDisposable
    {
        private SqlConnection _connection;

        public DataAccess()
        {
            var connectionString = $"Server={Program.DataSource};Database={Program.DatabaseName};";

            if(Program.UserId.IsNullOrEmpty() || Program.Password.IsNullOrEmpty())
            {
                connectionString += "Integrated Security=true";
            }
            else
            {
                connectionString += $"User Id ={Program.UserId};Password={Program.Password};";
            }

            _connection = new SqlConnection(connectionString);
        }

        public void Open()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        public void Close()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public DataTable GetData(string query, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = query;
            sqlcmd.Connection = _connection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void Dispose()
        {
            Close();
        }
    }
}
