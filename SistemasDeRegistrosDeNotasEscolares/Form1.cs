using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SistemasDeRegistrosDeNotasEscolares
{
    public partial class SistemaDeRegistroNotasEscolares : Form
    {
    
       
        private string connectionString = "Server=DESKTOP-ERBT3FI\\SQLEXPRESS;Database=SistemaNotas;Integrated Security=True;";

        public SistemaDeRegistroNotasEscolares()
        {
            InitializeComponent();
        }
        private void SistemaDeRegistroNotasEscolares_Load(object sender, EventArgs e)
        {

        }
        private void etudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstudiantes Frm = new FrmEstudiantes(connectionString); 
            Frm.Show();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestiondeMaterias Frm = new FrmGestiondeMaterias(connectionString); 
           
            Frm.Show();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRegistrodeNotas Frm = new FrmRegistrodeNotas(connectionString);
            
            Frm.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReportesdeNotas Frm = new FrmReportesdeNotas(connectionString);
            
            Frm.Show();
        }
    }
}
