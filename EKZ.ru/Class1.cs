using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace bdTestirovanie
{
    public class DataBase
    {
        SqlConnection _connection = new SqlConnection("Server = db.edu.cchgeu.ru; DataBase = 201s_Simonov; User = 201s_Simonov; Password = QazWsxEdc123");

        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return _connection;
        }

    }
}
