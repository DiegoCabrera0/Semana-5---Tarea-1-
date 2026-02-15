using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiondeTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Evento para agregar una tarea
        private void button1_Click(object sender, EventArgs e)
        {
            string tarea = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(tarea) && tarea != "ingresar tareas")
            {
                listBox2.Items.Add(tarea);
                textBox1.Clear(); 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una tarea válida.");
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una tarea para eliminar.");
            }
        }

        
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
