using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahsel.Winform.Connection
{
    public class ConnectionConfiguration : IConnectionConfiguration
    {
        public string ConnectionString { get; set; }

        public ConnectionConfiguration() { }

        public ConnectionConfiguration(string connectionString) { ConnectionString = connectionString; }

        public SqlConnection Create()
        {
            SqlConnection sqlConnection = new SqlConnection(ConnectionString);
            sqlConnection.Open();
            return sqlConnection;
        }
    }
}
