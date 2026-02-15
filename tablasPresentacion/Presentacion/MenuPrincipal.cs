using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tablasPresentacion.Presentacion.Autores;

namespace tablasPresentacion.Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autores.Frmautores form1 = new Autores.Frmautores();
            form1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Editores.Frmeditores form1 = new Editores.Frmeditores();
            form1.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            InformacionEditorial.FrmInformacionEditorial form1 = new InformacionEditorial.FrmInformacionEditorial();
            form1.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Titulos.FrmTitulos form1 = new Titulos.FrmTitulos();
            form1.ShowDialog();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tiendas.FrmTiendas form1 = new Tiendas.FrmTiendas();
            form1.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Empleados.Frmempleados form1 = new Empleados.Frmempleados();
            form1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Libros.Frmlibros form1 = new Libros.Frmlibros();
            form1.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ventas.Frmventas form1 = new Ventas.Frmventas();
            form1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CalendarioRegalias.FrmCalendarioRegalias form1 = new CalendarioRegalias.FrmCalendarioRegalias();
            form1.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Editores.Frmeditores form1 = new Editores.Frmeditores();
            form1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Descuentos.FrmDescuentos form1 = new Descuentos.FrmDescuentos();
            form1.ShowDialog();
        }
    }
}
