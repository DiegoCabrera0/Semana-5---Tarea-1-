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

    public partial class FrmAgregarLibro : Form
    {

        private Conexion conexion;  // Objeto para la conexión

        public FrmAgregarLibro()
        {
            InitializeComponent();
            conexion = new Conexion();
            CargarAutores();  // Cargar la lista de autores al abrir
        }
        private void CargarAutores()
        {
            try
            {
                using (SqlConnection conn = new Conexion().GetConnection())  // Usamos la conexión
                {
                    conn.Open();
                    string query = "SELECT ID, Nombre FROM Autor";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbAutor.DataSource = dt;
                        cmbAutor.DisplayMember = "Nombre";
                        cmbAutor.ValueMember = "ID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar autores: " + ex.Message);
            }
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbAutor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtEditorial_TextChanged(object sender, EventArgs e)
        {

        }

        private void numAnio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            int autorID = Convert.ToInt32(cmbAutor.SelectedValue);
            string editorial = txtEditorial.Text.Trim();
            int anioPublicacion = Convert.ToInt32(numAnio.Value);

            if (string.IsNullOrEmpty(titulo))
            {
                MessageBox.Show("El título del libro es obligatorio.");
                return;
            }

            try
            {
                using (SqlConnection conn = conexion.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Libro (Titulo, AutorID, Editorial, AnioPublicacion) VALUES (@Titulo, @AutorID, @Editorial, @Anio)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", titulo);
                        cmd.Parameters.AddWithValue("@AutorID", autorID);
                        cmd.Parameters.AddWithValue("@Editorial", editorial);
                        cmd.Parameters.AddWithValue("@Anio", anioPublicacion);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Libro agregado correctamente.");
                        this.Close(); // Cierra el formulario después de agregar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar libro: " + ex.Message);
            }
        }

        private void FrmAgregarLibro_Load(object sender, EventArgs e)
        {

        }
    }
}
