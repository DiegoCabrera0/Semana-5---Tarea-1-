using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.DAL;

namespace SistemaBiblioteca
{
    public partial class FrmAgregarAutor : Form
    {
        private Conexion conexion;  // Objeto para la conexión
        public FrmAgregarAutor()
        {
            InitializeComponent();
            conexion = new Conexion();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNacionalidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string nacionalidad = txtNacionalidad.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(nacionalidad))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Autor (Nombre, Nacionalidad) VALUES (@Nombre, @Nacionalidad)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Nacionalidad", nacionalidad);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Autor agregado correctamente.");
                        this.Close(); // Cierra el formulario después de agregar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar autor: " + ex.Message);
            }
        }
    }
}
