using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestiondeCursosyEstudiantes
{
    public partial class Form1 : Form
    {
        // Listas para almacenar estudiantes, cursos e inscripciones
        private List<Estudiante> estudiantes = new List<Estudiante>();
        private List<Curso> cursos = new List<Curso>();
        private List<Inscripcion> inscripciones = new List<Inscripcion>();

        public Form1()
        {
            InitializeComponent();

            // Configurar las columnas del DataGridView
            dataGridView1.Columns.Add("Estudiante", "Estudiante");
            dataGridView1.Columns.Add("Curso", "Curso");

            // Puedes ajustar el ancho de las columnas si lo deseas
            dataGridView1.Columns[0].Width = 150; // Columna Estudiante
            dataGridView1.Columns[1].Width = 150; // Columna Curso
        }

        // Clase Estudiante
        public class Estudiante
        {
            public string Nombre { get; set; }

            public Estudiante(string nombre)
            {
                Nombre = nombre;
            }
        }

        // Clase Curso
        public class Curso
        {
            public string Nombre { get; set; }

            public Curso(string nombre)
            {
                Nombre = nombre;
            }
        }

        // Clase Inscripción
        public class Inscripcion
        {
            public Estudiante Estudiante { get; set; }
            public Curso Curso { get; set; }

            public Inscripcion(Estudiante estudiante, Curso curso)
            {
                Estudiante = estudiante;
                Curso = curso;
            }
        }

        // Función para agregar un estudiante
        private void button1_Click(object sender, EventArgs e)
        {
            string nombreEstudiante = textBox1.Text;
            if (!string.IsNullOrEmpty(nombreEstudiante))
            {
                Estudiante nuevoEstudiante = new Estudiante(nombreEstudiante);
                estudiantes.Add(nuevoEstudiante);
                comboBox1.Items.Add(nuevoEstudiante.Nombre); // Agrega el estudiante al ComboBox
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre de estudiante.");
            }
        }

        // Función para agregar un curso
        private void button2_Click(object sender, EventArgs e)
        {
            string nombreCurso = textBox2.Text;
            if (!string.IsNullOrEmpty(nombreCurso))
            {
                Curso nuevoCurso = new Curso(nombreCurso);
                cursos.Add(nuevoCurso);
                comboBox2.Items.Add(nuevoCurso.Nombre); // Agrega el curso al ComboBox
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese un nombre de curso.");
            }
        }

        // Función para inscribir un estudiante a un curso
        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                // Obtener el estudiante seleccionado
                string estudianteNombre = comboBox1.SelectedItem.ToString();
                Estudiante estudianteSeleccionado = estudiantes.FirstOrDefault(estudiante => estudiante.Nombre == estudianteNombre);

                // Obtener el curso seleccionado
                string cursoNombre = comboBox2.SelectedItem.ToString();
                Curso cursoSeleccionado = cursos.FirstOrDefault(c => c.Nombre == cursoNombre);

                // Crear una nueva inscripción
                if (estudianteSeleccionado != null && cursoSeleccionado != null)
                {
                    Inscripcion nuevaInscripcion = new Inscripcion(estudianteSeleccionado, cursoSeleccionado);
                    inscripciones.Add(nuevaInscripcion);

                    // Mostrar la inscripción en el DataGridView
                    dataGridView1.Rows.Add(estudianteSeleccionado.Nombre, cursoSeleccionado.Nombre);
                }
                else
                {
                    MessageBox.Show("Selecciona un estudiante y un curso.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un estudiante y un curso.");
            }
        }

        // Métodos vacíos para manejar eventos (si los tienes en tu diseño, como los de ComboBox, etc.)
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
