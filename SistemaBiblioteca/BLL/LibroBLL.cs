using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DAL;

namespace Biblioteca.BLL
{
    public class LibroBLL
    {
        private LibroDAL libroDAL = new LibroDAL();

        public bool AgregarLibro(string titulo, string autor, string editorial, int anioPublicacion)
        {
            return libroDAL.InsertarLibro(titulo, autor, editorial, anioPublicacion);
        }

        public DataTable MostrarLibros()
        {
            return libroDAL.ObtenerLibros();
        }

        public bool EditarLibro(int id, string titulo, string autor, string editorial, int anioPublicacion)
        {
            return libroDAL.ActualizarLibro(id, titulo, autor, editorial, anioPublicacion);
        }

        public bool BorrarLibro(int id)
        {
            return libroDAL.EliminarLibro(id);
        }
    }
}