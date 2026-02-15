using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaDeReservasHotel
{
    public partial class Form1 : Form
    {
        private List<Habitacion> habitaciones = new List<Habitacion>();
        private List<Reserva> reservas = new List<Reserva>();

        public Form1()
        {
            InitializeComponent();
        }

        public class Habitacion
        {
            public string Nombre { get; set; }
            public string Tipo { get; set; }

            public Habitacion(string nombre, string tipo)
            {
                Nombre = nombre;
                Tipo = tipo;
            }
        }

        public class Reserva
        {
            public string NombreCliente { get; set; }
            public Habitacion Habitacion { get; set; }
            public DateTime FechaEntrada { get; set; }
            public DateTime FechaSalida { get; set; }

            public Reserva(string nombreCliente, Habitacion habitacion, DateTime fechaEntrada, DateTime fechaSalida)
            {
                NombreCliente = nombreCliente;
                Habitacion = habitacion;
                FechaEntrada = fechaEntrada;
                FechaSalida = fechaSalida;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            habitaciones.Add(new Habitacion("101", "Simple"));
            habitaciones.Add(new Habitacion("102", "Doble"));
            habitaciones.Add(new Habitacion("103", "Suite"));
            habitaciones.Add(new Habitacion("104", "Doble"));

            foreach (var habitacion in habitaciones)
            {
                comboBox1.Items.Add(habitacion.Nombre + " - " + habitacion.Tipo);
            }

            dataGridView1.Columns.Add("Cliente", "Cliente");
            dataGridView1.Columns.Add("Habitacion", "Habitación");
            dataGridView1.Columns.Add("FechaEntrada", "Fecha Entrada");
            dataGridView1.Columns.Add("FechaSalida", "Fecha Salida");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && !string.IsNullOrEmpty(textBox1.Text) && dateTimePicker1.Value < dateTimePicker2.Value)
            {
                string habitacionSeleccionada = comboBox1.SelectedItem.ToString().Split('-')[0].Trim();
                Habitacion habitacion = habitaciones.Find(h => h.Nombre == habitacionSeleccionada);

                Reserva nuevaReserva = new Reserva(
                    textBox1.Text,
                    habitacion,
                    dateTimePicker1.Value,
                    dateTimePicker2.Value
                );

                reservas.Add(nuevaReserva);

                dataGridView1.Rows.Add(nuevaReserva.NombreCliente, nuevaReserva.Habitacion.Nombre, nuevaReserva.FechaEntrada.ToShortDateString(), nuevaReserva.FechaSalida.ToShortDateString());

                textBox1.Clear();
                comboBox1.SelectedIndex = -1;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
            }
            else
            {
                MessageBox.Show("Por favor ingresa todos los campos correctamente.");
            }
        }

        // Evento para el ComboBox1
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica adicional aquí si es necesario, por ejemplo, mostrar algo en función de la selección
        }
    }
}
