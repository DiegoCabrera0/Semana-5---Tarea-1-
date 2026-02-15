using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistemaDeAlarmasGym.ventanas_de_ejercicios;

namespace sistemaDeAlarmasGym
{
    public partial class bitacorasdeejercicios : Form
    {
        public bitacorasdeejercicios()
        {
            InitializeComponent();
        }

        private void bitacorasdeejercicios_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 formPrincipal = Application.OpenForms["Form1"] as Form1;
            if (formPrincipal != null)
            {
                formPrincipal.RegistrarEjercicio("Piernas y Cardio");
                this.Close(); // cerramos esta ventana y volvemos al Form1
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            piernasycardioejercicios ventanaSeguridad = new piernasycardioejercicios();
            ventanaSeguridad.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PechosyCardio ventanaSeguridad = new PechosyCardio();
            ventanaSeguridad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 formPrincipal = Application.OpenForms["Form1"] as Form1;
            if (formPrincipal != null)
            {
                formPrincipal.RegistrarEjercicio("Pechos y Cardio");
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 formPrincipal = Application.OpenForms["Form1"] as Form1;
            if (formPrincipal != null)
            {
                formPrincipal.RegistrarEjercicio("Brazos y Abdomen");
                this.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 formPrincipal = Application.OpenForms["Form1"] as Form1;
            if (formPrincipal != null)
            {
                formPrincipal.RegistrarEjercicio("Cardio y Abdomen");
                this.Close();
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            brazosyabdomen ventanaSeguridad = new brazosyabdomen();
            ventanaSeguridad.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            cardioyabdomen ventanaSeguridad = new cardioyabdomen();
            ventanaSeguridad.Show();
        }
    }
}
