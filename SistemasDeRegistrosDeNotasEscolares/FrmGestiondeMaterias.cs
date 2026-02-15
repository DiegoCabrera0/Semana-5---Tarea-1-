using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemasDeRegistrosDeNotasEscolares
{
    public partial class FrmGestiondeMaterias : Form
    {
        private string connectionString = "Server=DESKTOP-ERBT3FI\\SQLEXPRESS;Database=SistemaNotas;Integrated Security = True;";

        public FrmGestiondeMaterias()
        {
            InitializeComponent();
        }

        public FrmGestiondeMaterias(string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
        }

        private void FrmGestiondeMaterias_Load(object sender, EventArgs e)
        {
            CargarMaterias();
        }

   
        private void CargarMaterias()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT IdMateria, Nombre FROM Materias";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar materias: " + ex.Message);
                }
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ingrese el nombre de la materia.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Materias (Nombre) VALUES (@nombre)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Materia agregada correctamente.");
                    CargarMaterias();
                    textBox1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar materia: " + ex.Message);
                }
            }
        }

        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                textBox1.Tag = dataGridView1.Rows[e.RowIndex].Cells["IdMateria"].Value.ToString(); 
            }
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Tag == null)
            {
                MessageBox.Show("Seleccione una materia para editar.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Materias SET Nombre = @nombre WHERE IdMateria = @id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nombre", textBox1.Text);
                    cmd.Parameters.AddWithValue("@id", textBox1.Tag);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Materia actualizada correctamente.");
                    CargarMaterias();
                    textBox1.Clear();
                    textBox1.Tag = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar materia: " + ex.Message);
                }
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Tag == null)
            {
                MessageBox.Show("Seleccione una materia para eliminar.");
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta materia?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM Materias WHERE IdMateria = @id";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@id", textBox1.Tag);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Materia eliminada correctamente.");
                        CargarMaterias();
                        textBox1.Clear();
                        textBox1.Tag = null;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar materia: " + ex.Message);
                    }
                }
            }
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todos los cambios se guardan automáticamente.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
