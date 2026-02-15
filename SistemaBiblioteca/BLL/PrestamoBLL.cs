using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Biblioteca.DAL;

namespace Biblioteca.BLL
{
    public class PrestamoBLL
    {
        private PrestamoDAL prestamoDAL = new PrestamoDAL();

        public bool AgregarPrestamo(int idLibro, int idUsuario, DateTime fechaSalida, DateTime fechaPrestamo)
        {
            return prestamoDAL.InsertarPrestamo(idLibro, idUsuario, fechaSalida, fechaPrestamo);
        }

        public DataTable MostrarPrestamos()
        {
            return prestamoDAL.ObtenerPrestamos();
        }

        public bool DevolverLibro(int id, DateTime fechaDevolucion)
        {
            return prestamoDAL.DevolverLibro(id, fechaDevolucion);
        }

        public bool BorrarPrestamo(int id)
        {
            return prestamoDAL.EliminarPrestamo(id);
        }
    }
}