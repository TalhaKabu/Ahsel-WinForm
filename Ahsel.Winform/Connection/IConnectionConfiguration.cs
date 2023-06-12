using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahsel.Winform.Connection
{
    public interface IConnectionConfiguration
    {
        public string ConnectionString { get; set; }
        SqlConnection Create();
    }
}
