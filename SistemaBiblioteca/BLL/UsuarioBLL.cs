using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DAL;

namespace Biblioteca.BLL
{
    public class UsuarioBLL
    {
        private UsuarioDAL usuarioDAL = new UsuarioDAL();

        // Agregar usuario
        public bool AgregarUsuario(string nombre, string correo, string telefono)
        {
            return usuarioDAL.InsertarUsuario(nombre, correo, telefono);  // No es necesario pasar 'conn'
        }

        // Mostrar todos los usuarios
        public DataTable MostrarUsuarios()
        {
            return usuarioDAL.ObtenerUsuarios();  // No se pasa 'conn'
        }

        // Editar usuario
        public bool EditarUsuario(int id, string nombre, string correo, string telefono)
        {
            return usuarioDAL.ActualizarUsuario(id, nombre, correo, telefono);  // No es necesario pasar 'conn'
        }

        // Borrar usuario
        public bool BorrarUsuario(int id)
        {
            return usuarioDAL.EliminarUsuario(id);  // No se pasa 'conn'
        }
    }
}