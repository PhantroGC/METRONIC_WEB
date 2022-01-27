using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CL_Connection
    {
        private SqlConnection Connection;
        private string ConnectionString;
        public SqlConnection Conexion() 
        {
            ConnectionString = "Data Source=LAPTOP-GC2020; Initial Catalog=BD_Sistema_Usuario; Integrated Security=true";
            Connection = new SqlConnection(ConnectionString);
            return Connection;
        }
    }
}
