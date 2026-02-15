using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteca.DAL
{
    public class Conexion
    {
        // Método actualizado para obtener la conexión con SQL Server
        public SqlConnection GetConnection()
        {
            // Cadena de conexión para SQL Server
            string connectionString = @"Server=DESKTOP-ERBT3FI\SQLEXPRESS;Database=Biblioteca;Integrated Security=True;";
            return new SqlConnection(connectionString);  // Devuelve la conexión SQL Server
        }
    }
}