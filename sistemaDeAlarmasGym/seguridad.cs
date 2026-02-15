using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaDeAlarmasGym
{
    public partial class seguridad : Form
    {
        SerialPort puerto;
        public seguridad()
        {
            InitializeComponent();
        }


        private void seguridad_Load(object sender, EventArgs e)
        {
            puerto = new SerialPort("COM3", 9600); // Reemplaza con el puerto correcto
            try
            {
                if (!puerto.IsOpen)
                    puerto.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el puerto: " + ex.Message);
            }

        }

        private void btnEncenderAlarma_Click(object sender, EventArgs e)
        {
            if (puerto != null && puerto.IsOpen)
            {
                puerto.Write("1");
                MessageBox.Show("Alarma encendida.");
            }
        }

        private void btnApagarAlarma_Click(object sender, EventArgs e)
        {
            if (puerto != null && puerto.IsOpen)
            {
                puerto.Write("0");
                MessageBox.Show("Alarma apagada.");
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (puerto != null && puerto.IsOpen)
                puerto.Close();

            base.OnFormClosing(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
