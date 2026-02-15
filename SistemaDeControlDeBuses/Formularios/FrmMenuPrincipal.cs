using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeControlDeBuses.Formularios;

namespace SistemaDeControlDeBuses
{
    public partial class MenuPrincipal : Form
    {
        private static string cadenaConexion = "Server=DESKTOP-ERBT3FI\\SQLEXPRESS;Database=SistemaControlBuses;Integrated Security=True;";

        public static SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FrmBuses frm = new FrmBuses();
            frm.Show();

        }

        private void Conductores_Click(object sender, EventArgs e)
        {
            FrmConductores frm = new FrmConductores();
            frm.Show();
        }

        private void botonRutas_Click(object sender, EventArgs e)
        {
            FrmRutas frm = new FrmRutas();  
            frm.Show();

        }

        private void botonViajesyboletos_Click(object sender, EventArgs e)
        {
            FrmBoletos frm = new FrmBoletos();
            frm.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
