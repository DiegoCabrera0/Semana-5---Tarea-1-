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
    public class LibroDAL
    {
        private Conexion conexion = new Conexion();

        // Insertar un nuevo libro
        public bool InsertarLibro(string titulo, string autor, string editorial, int anioPublicacion)
        {
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Libro (Titulo, Autor, Editorial, AñoPublicacion) VALUES (@Titulo, @Autor, @Editorial, @AñoPublicacion)";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usa SqlCommand
                    cmd.Parameters.AddWithValue("@Titulo", titulo);
                    cmd.Parameters.AddWithValue("@Autor", autor);
                    cmd.Parameters.AddWithValue("@Editorial", editorial);
                    cmd.Parameters.AddWithValue("@AñoPublicacion", anioPublicacion);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        // Obtener todos los libros
        public DataTable ObtenerLibros()
        {
            DataTable dtLibros = new DataTable();
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Libro";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usa SqlCommand
                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Usa SqlDataAdapter
                    da.Fill(dtLibros);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return dtLibros;
        }

        // Actualizar libro
        public bool ActualizarLibro(int id, string titulo, string autor, string editorial, int anioPublicacion)
        {
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Libro SET Titulo=@Titulo, Autor=@Autor, Editorial=@Editorial, AñoPublicacion=@AñoPublicacion WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usa SqlCommand
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@Titulo", titulo);
                    cmd.Parameters.AddWithValue("@Autor", autor);
                    cmd.Parameters.AddWithValue("@Editorial", editorial);
                    cmd.Parameters.AddWithValue("@AñoPublicacion", anioPublicacion);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        // Eliminar libro
        public bool EliminarLibro(int id)
        {
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Libro WHERE ID=@ID";
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