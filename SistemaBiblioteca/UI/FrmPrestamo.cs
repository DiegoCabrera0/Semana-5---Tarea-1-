using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;  // Cambio a SQL Server
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.BLL;
using Biblioteca.DAL;

namespace SistemaBiblioteca
{
    public partial class FrmPrestamo : Form
    {
        private Conexion conexion;  // Variable para la conexión
        private PrestamoDAL prestamoDAL;  // Variable para la capa DAL de préstamos

        public FrmPrestamo()
        {
            InitializeComponent();
            conexion = new Conexion();  // Inicializar la conexión
            prestamoDAL = new PrestamoDAL();  // Inicializar la capa DAL
        }

        private void dtpFechaSalida_ValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmbLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles en el formulario
            int idUsuario = Convert.ToInt32(cmbUsuario.SelectedValue);
            int idLibro = Convert.ToInt32(cmbLibro.SelectedValue);
            DateTime fechaSalida = dtpFechaSalida.Value;
            DateTime fechaPrestamo = dtpFechaPrestamo.Value;

            // Registrar el préstamo
            if (prestamoDAL.InsertarPrestamo(idLibro, idUsuario, fechaSalida, fechaPrestamo))
            {
                MessageBox.Show("Préstamo registrado correctamente.");
                CargarPrestamos();  // Cargar los préstamos actuales
            }
            else
            {
                MessageBox.Show("Error al registrar el préstamo.");
            }
        }

        private void dtpFechaPrestamo_ValueChanged(object sender, EventArgs e)
        {
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            CargarUsuario();  // Cargar los usuarios
            CargarLibros();  // Cargar los libros
            CargarPrestamos();  // Cargar los préstamos
        }

        private void CargarPrestamos()
        {
            // Obtener los préstamos mediante la capa DAL y asignarlos al DataGridView
            dgvPrestamos.DataSource = prestamoDAL.ObtenerPrestamos();
        }

        private void CargarUsuario()
        {
            // Cargar los usuarios en el ComboBox
            try
            {
                using (var conn = conexion.GetConnection())  // Usamos la conexión ya inicializada
                {
                    conn.Open();
                    string query = "SELECT ID, Nombre FROM Usuario";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usamos SqlCommand para SQL Server
                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Usamos SqlDataAdapter para SQL Server
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbUsuario.DataSource = dt;
                    cmbUsuario.DisplayMember = "Nombre";
                    cmbUsuario.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message);
            }
        }

        private void CargarLibros()
        {
            // Cargar los libros en el ComboBox
            try
            {
                using (var conn = conexion.GetConnection())  // Usamos la conexión ya inicializada
                {
                    conn.Open();
                    string query = "SELECT ID, Titulo FROM Libro";
                    SqlCommand cmd = new SqlCommand(query, conn);  // Usamos SqlCommand para SQL Server
                    SqlDataAdapter da = new SqlDataAdapter(cmd);  // Usamos SqlDataAdapter para SQL Server
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cmbLibro.DataSource = dt;
                    cmbLibro.DisplayMember = "Titulo";
                    cmbLibro.ValueMember = "ID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar libros: " + ex.Message);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            // Marcar un préstamo como devuelto
            if (dgvPrestamos.SelectedRows.Count > 0)
            {
                int idPrestamo = Convert.ToInt32(dgvPrestamos.SelectedRows[0].Cells["ID"].Value);
                DateTime fechaDevolucion = DateTime.Now;

                if (prestamoDAL.DevolverLibro(idPrestamo, fechaDevolucion))
                {
                    MessageBox.Show("Libro devuelto correctamente.");
                    CargarPrestamos();  // Actualizar la lista de préstamos
                }
                else
                {
                    MessageBox.Show("Error al devolver el libro.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un préstamo para marcar como devuelto.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuario frm = new FrmAgregarUsuario();
            frm.ShowDialog();  // Mostrar el formulario como ventana modal

            // Recargar la lista de usuarios después de agregar uno nuevo
            CargarUsuario();
        }

        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            FrmAgregarLibro frm = new FrmAgregarLibro();
            frm.ShowDialog();  // Mostrar el formulario como ventana modal

            // Recargar la lista de libros después de agregar uno nuevo
            CargarLibros();
        }

        private void btnAgregarAutor_Click(object sender, EventArgs e)
        {
            FrmAgregarAutor frm = new FrmAgregarAutor();
            frm.ShowDialog();  // Abre el formulario de autores

            CargarAutores();  // Recargar autores después de cerrar el formulario
        }

        private void CargarAutores()
        {
         
        }
    }
}