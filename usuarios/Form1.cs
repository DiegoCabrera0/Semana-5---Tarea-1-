using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usuarios.Controladores;
namespace usuarios
{
    public partial class Form1 : Form
    {
        private occunt_coontroller cuentas_accesos = new occunt_coontroller();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var usuario = cuentas_accesos.login(txtusuario.Text.Trim(), txtContraseña.Text.Trim());
            if (usuario.Detalle_Rol == null) 
            {
                MessageBox.Show("el usuario o la contraseña es incorrecta");
            }
            else {
                MessageBox.Show("Bienvenido al sistema jefe");
            }
        }
    }
}
