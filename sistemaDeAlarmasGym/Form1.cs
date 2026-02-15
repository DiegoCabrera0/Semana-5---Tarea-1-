using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaDeAlarmasGym;

namespace sistemaDeAlarmasGym
{

    public partial class Form1 : Form
    {

        List<Usuario> listaUsuarios = new List<Usuario>();
        Usuario usuarioActual;

        public void RegistrarEjercicio(string tipo)
        {
            if (usuarioActual != null)
            {
                usuarioActual.TipoEjercicio = tipo;
                MessageBox.Show($"Ejercicio de hoy registrado: {tipo}");
                MostrarUsuarios(); // actualiza el DataGridView
            }
            else
            {
                MessageBox.Show("Primero registre un usuario.");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();

            var usuario = listaUsuarios.FirstOrDefault(u => u.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (usuario != null && usuario.Salida == null)
            {
                usuario.Salida = DateTime.Now;
                MessageBox.Show($"Salida registrada para: {usuario.Nombre}");
                MostrarUsuarios();
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (usuarioActual != null)
            {
                usuarioActual.Ingreso = DateTime.Now;
                MessageBox.Show("Ingreso registrado.");
            }
            else
            {
                MessageBox.Show("Primero registre un usuario.");
            }
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (usuarioActual != null)
            {
                usuarioActual.Salida = DateTime.Now;
                listaUsuarios.Add(usuarioActual);
                MostrarUsuarios();
                usuarioActual = null;
                MessageBox.Show("Salida registrada y usuario guardado.");
            }
            else
            {
                MessageBox.Show("Primero registre un usuario.");
            }
        }

        private void btnSeguridad_Click(object sender, EventArgs e)
        {
            seguridad ventanaSeguridad = new seguridad();
            ventanaSeguridad.Show();
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string nombreSeleccionado = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                var usuario = listaUsuarios.FirstOrDefault(u => u.Nombre.Equals(nombreSeleccionado, StringComparison.OrdinalIgnoreCase));

                if (usuario != null && usuario.Salida == null)
                {
                    usuario.Salida = DateTime.Now;
                    MessageBox.Show($"Salida registrada para: {usuario.Nombre}");
                    MostrarUsuarios();
                }
            }
        }

        private void botonregistrogym_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(nombre))
            {
                usuarioActual = new Usuario { Nombre = nombre };
                listaUsuarios.Add(usuarioActual); // <--- Agrega aquí
                MessageBox.Show("Usuario registrado. Ahora puedes registrar ingreso, ejercicio o salida.");
                MostrarUsuarios(); // actualiza la tabla
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un nombre.");
            }
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            string nombreBuscado = textBox1.Text.Trim();
            var resultado = listaUsuarios.FindAll(u => u.Nombre.Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase));

            if (resultado.Count > 0)
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = resultado;
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }

        private void MostrarUsuarios()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = listaUsuarios;
        }

        private void botonmostrarRegistro_Click(object sender, EventArgs e)
        {
            if (listaUsuarios.Count == 0)
            {
                MessageBox.Show("No hay usuarios registrados aún.");
                return;
            }

            var usuariosConRegistro = listaUsuarios.Select(u => new
            {
                Nombre = u.Nombre,
                Ingreso = u.Ingreso.HasValue ? u.Ingreso.Value.ToString("g") : "No registrado",
                Salida = u.Salida.HasValue ? u.Salida.Value.ToString("g") : "No registrado",
                Ejercicio = string.IsNullOrEmpty(u.TipoEjercicio) ? "No registrado" : u.TipoEjercicio
            }).ToList();

            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = usuariosConRegistro;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bitacorasdeejercicios ventanaSeguridad = new bitacorasdeejercicios();
            ventanaSeguridad.Show();
        }
    }
}
