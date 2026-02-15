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
    public partial class FrmEstudiantes : Form
    {
        // Constructor sin parámetros (predeterminado)
        public FrmEstudiantes()
        {
            InitializeComponent();
        }

        // Constructor adicional con parámetros
        public FrmEstudiantes(string parametro)
        {
            InitializeComponent();
            // Ejemplo de uso del parámetro
            MessageBox.Show($"El parámetro recibido es: {parametro}");
        }

        // Evento que se dispara cuando el formulario carga
        private void FrmEstudiantes_Load(object sender, EventArgs e)
        {
            // Inicializa cualquier dato necesario en la carga
            MessageBox.Show("Formulario cargado correctamente.");
        }

        // Evento para manejar clics en las celdas del DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Evitar clics en encabezados
            {
                MessageBox.Show($"Celda clickeada: Fila {e.RowIndex}, Columna {e.ColumnIndex}");
            }
        }

        // Evento para manejar cambios en el texto de textBox1
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Verificar que textBox1 no sea nulo antes de acceder a su texto
            if (textBox1 != null)
            {
                Console.WriteLine($"Texto cambiado en textBox1: {textBox1.Text}");
            }
        }

        // Evento para manejar selección de elementos en comboBox1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                MessageBox.Show($"Ítem seleccionado: {comboBox1.SelectedItem}");
            }
        }

        // Evento para manejar cambios en el texto de textBox2
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2 != null)
            {
                Console.WriteLine($"Texto cambiado en textBox2: {textBox2.Text}");
            }
        }

        // Evento del botón Agregar
        private void Agregar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón Agregar clickeado.");
        }

        // Evento del botón Editar
        private void Editar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón Editar clickeado.");
        }

        // Evento del botón Eliminar
        private void Eliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón Eliminar clickeado.");
        }

        // Evento del botón Guardar
        private void Guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Botón Guardar clickeado.");
        }
    }
}