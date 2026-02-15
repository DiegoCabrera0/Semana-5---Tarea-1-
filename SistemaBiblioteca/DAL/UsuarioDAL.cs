using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteca.DAL
{
    public class UsuarioDAL
    {
        private Conexion conexion = new Conexion();

        // Insertar usuario
        public bool InsertarUsuario(string nombre, string correo, string telefono)
        {
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Usuario (Nombre, Correo, Telefono) VALUES (@Nombre, @Correo, @Telefono)";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usa SqlCommand
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        // Obtener todos los usuarios
        public DataTable ObtenerUsuarios()
        {
            DataTable dtUsuarios = new DataTable();
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Usuario";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usa SqlCommand
                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Usa SqlDataAdapter
                    da.Fill(dtUsuarios);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return dtUsuarios;
        }

        // Actualizar usuario
        public bool ActualizarUsuario(int id, string nombre, string correo, string telefono)
        {
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Usuario SET Nombre=@Nombre, Correo=@Correo, Telefono=@Telefono WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usa SqlCommand
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        // Eliminar usuario
        public bool EliminarUsuario(int id)
        {
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Usuario WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usa SqlCommand
                    cmd.Parameters.AddWithValue("@ID", id);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }
    }
}