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
    public partial class FrmAgregarUsuario : Form
    {
        private Conexion conexion;  // Objeto para la conexión
        public FrmAgregarUsuario()
        {
            InitializeComponent();
            conexion = new Conexion();  // Inicializamos la conexión
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string telefono = txtTelefono.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("El nombre y correo son obligatorios.");
                return;
            }

            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Usuario (Nombre, Correo, Telefono) VALUES (@Nombre, @Correo, @Telefono)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", nombre);
                        cmd.Parameters.AddWithValue("@Correo", correo);
                        cmd.Parameters.AddWithValue("@Telefono", telefono);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario agregado correctamente.");
                        this.Close(); // Cierra el formulario después de agregar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario: " + ex.Message);
            }
        

        }
    }
}
