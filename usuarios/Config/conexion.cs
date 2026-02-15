using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace usuarios.Config
{
    internal class conexion
    {
        private readonly string cadenaConexion =
            "server=(local);database=Sistemasroles;uid=sa;pwd=123";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
