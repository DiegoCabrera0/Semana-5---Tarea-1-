using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Biblioteca.DAL
{
    public class PrestamoDAL
    {
        private Conexion conexion = new Conexion();

        // Insertar un nuevo préstamo
        public bool InsertarPrestamo(int idLibro, int idUsuario, DateTime fechaSalida, DateTime fechaPrestamo)
        {
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Prestamo (ID_Libro, ID_Usuario, FechaSalida, FechaPrestamo) VALUES (@ID_Libro, @ID_Usuario, @FechaSalida, @FechaPrestamo)";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usa SqlCommand
                    cmd.Parameters.AddWithValue("@ID_Libro", idLibro);
                    cmd.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                    cmd.Parameters.AddWithValue("@FechaSalida", fechaSalida);
                    cmd.Parameters.AddWithValue("@FechaPrestamo", fechaPrestamo);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        // Obtener todos los préstamos
        public DataTable ObtenerPrestamos()
        {
            DataTable dtPrestamos = new DataTable();
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT p.ID, u.Nombre AS Usuario, l.Titulo AS Libro, 
                                    p.FechaSalida, p.FechaPrestamo, p.FechaDevolucion, p.Devuelto 
                                    FROM Prestamo p
                                    JOIN Usuario u ON p.ID_Usuario = u.ID
                                    JOIN Libro l ON p.ID_Libro = l.ID";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usa SqlCommand
                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Usa SqlDataAdapter
                    da.Fill(dtPrestamos);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return dtPrestamos;
        }

        // Marcar un préstamo como devuelto
        public bool DevolverLibro(int id, DateTime fechaDevolucion)
        {
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Prestamo SET FechaDevolucion=@FechaDevolucion, Devuelto=1 WHERE ID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usa SqlCommand
                    cmd.Parameters.AddWithValue("@ID", id);
                    cmd.Parameters.AddWithValue("@FechaDevolucion", fechaDevolucion);
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                    return false;
                }
            }
        }

        // Eliminar préstamo
        public bool EliminarPrestamo(int id)
        {
            using (SqlConnection conn = conexion.GetConnection())  // Usa SqlConnection
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Prestamo WHERE ID=@ID";
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