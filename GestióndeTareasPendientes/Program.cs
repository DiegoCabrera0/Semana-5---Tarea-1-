using System;
using System.Windows.Forms;

namespace GestióndeTareasPendientes
{
    public partial class Form1 : Form
    {

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            string tarea = txtTarea.Text;
            if (!string.IsNullOrEmpty(tarea))
            {
                lstTareas.Items.Add(tarea); 
                txtTarea.Clear(); 
            }
            else
            {
                MessageBox.Show("Por favor, ingrese una tarea.");
            }
        }

      
        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedItem != null)
            {
                lstTareas.Items.Remove(lstTareas.SelectedItem); 
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una tarea para eliminar.");
            }
        }
    }
}
